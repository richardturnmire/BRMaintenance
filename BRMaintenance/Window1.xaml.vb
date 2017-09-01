Imports C1.WPF.C1DataGrid
Imports C1.WPF.C1Schedule
Imports BRMaintenance.BusinessReportsDataSetTableAdapters
Imports System.Data
Imports System.Linq

Class Window1

    Inherits Window
    'Private BatchData As IEnumerable(Of Batchtbl)
    'Private WorksrcData As IEnumerable(Of Wrksrctbl)
    Private db As BRDatabaseDataContext

    Private BatchViewSource As CollectionViewSource
    Private DetailViewSource As CollectionViewSource
    Private WorksrcViewSource As CollectionViewSource

    Private WithEvents BatchView As BindingListCollectionView
    Private DetailView As BindingListCollectionView
    Private WithEvents WorksrcView As BindingListCollectionView

    Private UpdatesCommitted As Boolean = True
    '                Style="{StaticResource {ComponentResourceKey ResourceId=CardViewStyle, TypeInTargetAssembly={x:Type c1grid:C1DataGrid}}}"


    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub C1MonthCalendar1_DateTimeChanged(ByVal sender As Object, ByVal e As C1.WPF.C1Schedule.DateTimePropertyChangeEventArgs)
        Me.WorksrcCombo.SelectedValue = 0
    End Sub

    Private Sub Window1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        If Not UpdatesCommitted Then
            CommitUpdates()
        End If

    End Sub

    'Private Sub UpdateView()
    '    Dim myfilter As String = "ProcessDt = '" & Me.C1MonthCalendar1.Date & "'"
    '    ' Dim myView As DataView = New DataView(BR_DataSet.Batchtbl, myfilter, "BatchNum", DataViewRowState.CurrentRows)
    '    Dim myview As DataView = BR_DataSet.Batchtbl.DefaultView
    '    myview.RowFilter = myfilter
    '    myview.Sort = "BatchNum"
    '    Me.C1DataGrid1.DataContext = myview
    'End Sub
    'Private Sub Item_GotFocus(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
    '    Dim item = CType(sender, C1.WPF.C1DataGrid.GridItem)
    '    Me.C1DataGrid1.SelectedGridItem.DataContext = item.DataContext
    'End Sub

    Private Sub Window1_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        db = New BRDatabaseDataContext


        Me.C1DateTimePicker1.Date = Date.Now          '.AddDays(-1)

        Dim worksrcList = From c In db.Wrksrctbls _
                              Select c.WorksrcNum, c.Name

        Me.WorksrcViewSource = CType(Me.FindResource("WorksrcView"), CollectionViewSource)
        Me.WorksrcViewSource.Source = worksrcList
        Me.WorksrcView = CType(Me.WorksrcViewSource.View, BindingListCollectionView)


        Me.Height = My.Computer.Screen.WorkingArea.Height
        Me.MaxHeight = Me.Height
        Me.Width = My.Computer.Screen.WorkingArea.Width
        Me.MaxWidth = Me.Width


    End Sub

    Private Sub BatchView_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BatchView.CurrentChanged
        If ComboBox2.SelectedIndex > -1 Then
            Button1.Content = ComboBox2.SelectedValue.ToString
            Button1.Visibility = Windows.Visibility.Visible
            UpdateDetailView()
        End If
    End Sub

    Private Sub WorksrcView_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WorksrcView.CurrentChanged
        If WorksrcCombo.SelectedIndex > -1 Then
            UpdateBatchView()
        End If
    End Sub

    Private Sub UpdateBatchView()
        Dim batches = From b In db.Batchtbls _
                      Where b.ProcessDt = Me.C1DateTimePicker1.Date.ToString("yyyy-MM-dd") _
                        And b.WorkSource = Me.WorksrcCombo.SelectedValue.ToString _
                      Order By b.BatchNum

        Me.BatchViewSource = CType(Me.FindResource("BatchView"), CollectionViewSource)
        Me.BatchViewSource.Source = batches
        Me.BatchView = CType(Me.BatchViewSource.View, BindingListCollectionView)

    End Sub

    Private Sub UpdateDetailView()
        Dim details = From d In db.DetailTbls _
                      Where d.ProcessDt = Me.C1DateTimePicker1.Date.ToString("yyyy-MM-dd") _
                        And d.WorkSource = Me.WorksrcCombo.SelectedValue.ToString _
                        And d.BatchNumber = Me.ComboBox2.SelectedValue.ToString _
                      Order By d.SeqNo, d.SubSeqNo

        Me.DetailViewSource = CType(Me.FindResource("DetailView"), CollectionViewSource)
        Me.DetailViewSource.Source = details
        Me.DetailView = CType(Me.DetailViewSource.View, BindingListCollectionView)
        C1DataGrid1.GroupByColumns.BeginUpdate()
        C1DataGrid1.GroupByColumns.Add(C1DataGrid1.ActualColumns.Item(2))
        C1DataGrid1.GroupByColumns.EndUpdate()
        C1DataGrid1.GroupByVisibility = Windows.Visibility.Collapsed
    End Sub

    Private Sub C1DateTimePicker1_DateTimeChanged(ByVal sender As Object, ByVal e As C1.WPF.C1Schedule.DateTimePropertyChangeEventArgs)
        If WorksrcCombo.SelectedIndex > -1 Then
            UpdateBatchView()
        End If
        If ComboBox2.SelectedIndex > -1 Then
            UpdateDetailView()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click
        Dim answer As MsgBoxResult = MsgBox("Do you really want to reset batch " & Button1.Content & "?", MsgBoxStyle.YesNo, Me.Title)
        If answer = MsgBoxResult.Yes Then
            UpdatesCommitted = False
            Dim currBatch As String = Button1.Content.ToString
            '
            '
            '
            Try
                Dim details = From g In db.DetailTbls _
                          Where g.ProcessDt = Me.C1DateTimePicker1.Date.ToString("yyyy-MM-dd") _
                            And g.WorkSource = Me.WorksrcCombo.SelectedValue.ToString _
                            And g.BatchNumber = currBatch

                For Each detail As DetailTbl In details
                    db.DetailTbls.DeleteOnSubmit(detail)
                Next
                DetailView.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error deleting detail for batch " & currBatch)
                Exit Sub
            End Try

            Try
                Dim batches = From h In db.Batchtbls _
                            Where (h.ProcessDt = Me.C1DateTimePicker1.Date.ToString("yyyy-MM-dd") _
                            And h.WorkSource = Me.WorksrcCombo.SelectedValue.ToString _
                            And h.BatchNum = currBatch)

                For Each batch As Batchtbl In batches
                    db.Batchtbls.DeleteOnSubmit(batch)
                    Me.BatchView.RemoveAt(Me.BatchView.CurrentPosition)
                Next
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error deleting batch " & currBatch)
                Exit Sub
            End Try


            MsgBox("Batch " & currBatch & " has been reset", MsgBoxStyle.OkOnly, Me.Title)

            Button2.Visibility = Windows.Visibility.Visible
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button2.Click
        CommitUpdates()
    End Sub
    Private Sub CommitUpdates()
        If MsgBox("Do you want to save your changes?", MsgBoxStyle.YesNo, Me.Title) = MsgBoxResult.Yes Then
            Try
                db.SubmitChanges(Linq.ConflictMode.FailOnFirstConflict)
                UpdatesCommitted = True
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf & ex.StackTrace)
            End Try
        End If

    End Sub

End Class



