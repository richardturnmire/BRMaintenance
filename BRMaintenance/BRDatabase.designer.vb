﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3521
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<System.Data.Linq.Mapping.DatabaseAttribute(Name:="BusinessReports")>  _
Partial Public Class BRDatabaseDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertBatchtbl(instance As Batchtbl)
    End Sub
  Partial Private Sub UpdateBatchtbl(instance As Batchtbl)
    End Sub
  Partial Private Sub DeleteBatchtbl(instance As Batchtbl)
    End Sub
  Partial Private Sub InsertDetailTbl(instance As DetailTbl)
    End Sub
  Partial Private Sub UpdateDetailTbl(instance As DetailTbl)
    End Sub
  Partial Private Sub DeleteDetailTbl(instance As DetailTbl)
    End Sub
  Partial Private Sub InsertWrksrctbl(instance As Wrksrctbl)
    End Sub
  Partial Private Sub UpdateWrksrctbl(instance As Wrksrctbl)
    End Sub
  Partial Private Sub DeleteWrksrctbl(instance As Wrksrctbl)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.BRMaintenance.MySettings.Default.BusinessReportsConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Batchtbls() As System.Data.Linq.Table(Of Batchtbl)
		Get
			Return Me.GetTable(Of Batchtbl)
		End Get
	End Property
	
	Public ReadOnly Property DetailTbls() As System.Data.Linq.Table(Of DetailTbl)
		Get
			Return Me.GetTable(Of DetailTbl)
		End Get
	End Property
	
	Public ReadOnly Property Wrksrctbls() As System.Data.Linq.Table(Of Wrksrctbl)
		Get
			Return Me.GetTable(Of Wrksrctbl)
		End Get
	End Property
End Class

<Table(Name:="dbo.Batchtbl")>  _
Partial Public Class Batchtbl
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ProcessDt As Date
	
	Private _WorkSource As String
	
	Private _BatchNum As String
	
	Private _Status As System.Nullable(Of Char)
	
	Private _SiteID As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnProcessDtChanging(value As Date)
    End Sub
    Partial Private Sub OnProcessDtChanged()
    End Sub
    Partial Private Sub OnWorkSourceChanging(value As String)
    End Sub
    Partial Private Sub OnWorkSourceChanged()
    End Sub
    Partial Private Sub OnBatchNumChanging(value As String)
    End Sub
    Partial Private Sub OnBatchNumChanged()
    End Sub
    Partial Private Sub OnStatusChanging(value As System.Nullable(Of Char))
    End Sub
    Partial Private Sub OnStatusChanged()
    End Sub
    Partial Private Sub OnSiteIDChanging(value As String)
    End Sub
    Partial Private Sub OnSiteIDChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Column(Storage:="_ProcessDt", DbType:="SmallDateTime NOT NULL", IsPrimaryKey:=true)>  _
	Public Property ProcessDt() As Date
		Get
			Return Me._ProcessDt
		End Get
		Set
			If ((Me._ProcessDt = value)  _
						= false) Then
				Me.OnProcessDtChanging(value)
				Me.SendPropertyChanging
				Me._ProcessDt = value
				Me.SendPropertyChanged("ProcessDt")
				Me.OnProcessDtChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_WorkSource", DbType:="Char(10) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property WorkSource() As String
		Get
			Return Me._WorkSource
		End Get
		Set
			If (String.Equals(Me._WorkSource, value) = false) Then
				Me.OnWorkSourceChanging(value)
				Me.SendPropertyChanging
				Me._WorkSource = value
				Me.SendPropertyChanged("WorkSource")
				Me.OnWorkSourceChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_BatchNum", DbType:="Char(10) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property BatchNum() As String
		Get
			Return Me._BatchNum
		End Get
		Set
			If (String.Equals(Me._BatchNum, value) = false) Then
				Me.OnBatchNumChanging(value)
				Me.SendPropertyChanging
				Me._BatchNum = value
				Me.SendPropertyChanged("BatchNum")
				Me.OnBatchNumChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Status", DbType:="Char(1)")>  _
	Public Property Status() As System.Nullable(Of Char)
		Get
			Return Me._Status
		End Get
		Set
			If (Me._Status.Equals(value) = false) Then
				Me.OnStatusChanging(value)
				Me.SendPropertyChanging
				Me._Status = value
				Me.SendPropertyChanged("Status")
				Me.OnStatusChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_SiteID", DbType:="VarChar(5)")>  _
	Public Property SiteID() As String
		Get
			Return Me._SiteID
		End Get
		Set
			If (String.Equals(Me._SiteID, value) = false) Then
				Me.OnSiteIDChanging(value)
				Me.SendPropertyChanging
				Me._SiteID = value
				Me.SendPropertyChanged("SiteID")
				Me.OnSiteIDChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Table(Name:="dbo.DetailTbl")>  _
Partial Public Class DetailTbl
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _SiteId As Short
	
	Private _ProcessDt As Date
	
	Private _WorkSource As String
	
	Private _BatchNumber As String
	
	Private _TranNo As Integer
	
	Private _SeqNo As Integer
	
	Private _SubSeqNo As Integer
	
	Private _P1ImgSeqNo As System.Nullable(Of Integer)
	
	Private _P2ImgSeqNo As System.Nullable(Of Integer)
	
	Private _ItemType As Char
	
	Private _BatchType As Short
	
	Private _Amount As String
	
	Private _UserString1 As String
	
	Private _UserString2 As String
	
	Private _UserString3 As String
	
	Private _UserString4 As String
	
	Private _UserString5 As String
	
	Private _UserString6 As String
	
	Private _UserString7 As String
	
	Private _UserString8 As String
	
	Private _UserField1 As String
	
	Private _UserField2 As String
	
	Private _UserInt1 As String
	
	Private _UserInt2 As String
	
	Private _UserInt3 As System.Nullable(Of Integer)
	
	Private _UserFlag1 As System.Nullable(Of Char)
	
	Private _UserFlag2 As System.Nullable(Of Char)
	
	Private _UserFlag3 As System.Nullable(Of Char)
	
	Private _Phone As String
	
	Private _Email As String
	
	Private _status As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnSiteIdChanging(value As Short)
    End Sub
    Partial Private Sub OnSiteIdChanged()
    End Sub
    Partial Private Sub OnProcessDtChanging(value As Date)
    End Sub
    Partial Private Sub OnProcessDtChanged()
    End Sub
    Partial Private Sub OnWorkSourceChanging(value As String)
    End Sub
    Partial Private Sub OnWorkSourceChanged()
    End Sub
    Partial Private Sub OnBatchNumberChanging(value As String)
    End Sub
    Partial Private Sub OnBatchNumberChanged()
    End Sub
    Partial Private Sub OnTranNoChanging(value As Integer)
    End Sub
    Partial Private Sub OnTranNoChanged()
    End Sub
    Partial Private Sub OnSeqNoChanging(value As Integer)
    End Sub
    Partial Private Sub OnSeqNoChanged()
    End Sub
    Partial Private Sub OnSubSeqNoChanging(value As Integer)
    End Sub
    Partial Private Sub OnSubSeqNoChanged()
    End Sub
    Partial Private Sub OnP1ImgSeqNoChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnP1ImgSeqNoChanged()
    End Sub
    Partial Private Sub OnP2ImgSeqNoChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnP2ImgSeqNoChanged()
    End Sub
    Partial Private Sub OnItemTypeChanging(value As Char)
    End Sub
    Partial Private Sub OnItemTypeChanged()
    End Sub
    Partial Private Sub OnBatchTypeChanging(value As Short)
    End Sub
    Partial Private Sub OnBatchTypeChanged()
    End Sub
    Partial Private Sub OnAmountChanging(value As String)
    End Sub
    Partial Private Sub OnAmountChanged()
    End Sub
    Partial Private Sub OnUserString1Changing(value As String)
    End Sub
    Partial Private Sub OnUserString1Changed()
    End Sub
    Partial Private Sub OnUserString2Changing(value As String)
    End Sub
    Partial Private Sub OnUserString2Changed()
    End Sub
    Partial Private Sub OnUserString3Changing(value As String)
    End Sub
    Partial Private Sub OnUserString3Changed()
    End Sub
    Partial Private Sub OnUserString4Changing(value As String)
    End Sub
    Partial Private Sub OnUserString4Changed()
    End Sub
    Partial Private Sub OnUserString5Changing(value As String)
    End Sub
    Partial Private Sub OnUserString5Changed()
    End Sub
    Partial Private Sub OnUserString6Changing(value As String)
    End Sub
    Partial Private Sub OnUserString6Changed()
    End Sub
    Partial Private Sub OnUserString7Changing(value As String)
    End Sub
    Partial Private Sub OnUserString7Changed()
    End Sub
    Partial Private Sub OnUserString8Changing(value As String)
    End Sub
    Partial Private Sub OnUserString8Changed()
    End Sub
    Partial Private Sub OnUserField1Changing(value As String)
    End Sub
    Partial Private Sub OnUserField1Changed()
    End Sub
    Partial Private Sub OnUserField2Changing(value As String)
    End Sub
    Partial Private Sub OnUserField2Changed()
    End Sub
    Partial Private Sub OnUserInt1Changing(value As String)
    End Sub
    Partial Private Sub OnUserInt1Changed()
    End Sub
    Partial Private Sub OnUserInt2Changing(value As String)
    End Sub
    Partial Private Sub OnUserInt2Changed()
    End Sub
    Partial Private Sub OnUserInt3Changing(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnUserInt3Changed()
    End Sub
    Partial Private Sub OnUserFlag1Changing(value As System.Nullable(Of Char))
    End Sub
    Partial Private Sub OnUserFlag1Changed()
    End Sub
    Partial Private Sub OnUserFlag2Changing(value As System.Nullable(Of Char))
    End Sub
    Partial Private Sub OnUserFlag2Changed()
    End Sub
    Partial Private Sub OnUserFlag3Changing(value As System.Nullable(Of Char))
    End Sub
    Partial Private Sub OnUserFlag3Changed()
    End Sub
    Partial Private Sub OnPhoneChanging(value As String)
    End Sub
    Partial Private Sub OnPhoneChanged()
    End Sub
    Partial Private Sub OnEmailChanging(value As String)
    End Sub
    Partial Private Sub OnEmailChanged()
    End Sub
    Partial Private Sub OnstatusChanging(value As String)
    End Sub
    Partial Private Sub OnstatusChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Column(Storage:="_SiteId", DbType:="SmallInt NOT NULL", IsPrimaryKey:=true)>  _
	Public Property SiteId() As Short
		Get
			Return Me._SiteId
		End Get
		Set
			If ((Me._SiteId = value)  _
						= false) Then
				Me.OnSiteIdChanging(value)
				Me.SendPropertyChanging
				Me._SiteId = value
				Me.SendPropertyChanged("SiteId")
				Me.OnSiteIdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ProcessDt", DbType:="DateTime NOT NULL", IsPrimaryKey:=true)>  _
	Public Property ProcessDt() As Date
		Get
			Return Me._ProcessDt
		End Get
		Set
			If ((Me._ProcessDt = value)  _
						= false) Then
				Me.OnProcessDtChanging(value)
				Me.SendPropertyChanging
				Me._ProcessDt = value
				Me.SendPropertyChanged("ProcessDt")
				Me.OnProcessDtChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_WorkSource", DbType:="Char(10) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property WorkSource() As String
		Get
			Return Me._WorkSource
		End Get
		Set
			If (String.Equals(Me._WorkSource, value) = false) Then
				Me.OnWorkSourceChanging(value)
				Me.SendPropertyChanging
				Me._WorkSource = value
				Me.SendPropertyChanged("WorkSource")
				Me.OnWorkSourceChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_BatchNumber", DbType:="Char(10) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property BatchNumber() As String
		Get
			Return Me._BatchNumber
		End Get
		Set
			If (String.Equals(Me._BatchNumber, value) = false) Then
				Me.OnBatchNumberChanging(value)
				Me.SendPropertyChanging
				Me._BatchNumber = value
				Me.SendPropertyChanged("BatchNumber")
				Me.OnBatchNumberChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_TranNo", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property TranNo() As Integer
		Get
			Return Me._TranNo
		End Get
		Set
			If ((Me._TranNo = value)  _
						= false) Then
				Me.OnTranNoChanging(value)
				Me.SendPropertyChanging
				Me._TranNo = value
				Me.SendPropertyChanged("TranNo")
				Me.OnTranNoChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_SeqNo", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property SeqNo() As Integer
		Get
			Return Me._SeqNo
		End Get
		Set
			If ((Me._SeqNo = value)  _
						= false) Then
				Me.OnSeqNoChanging(value)
				Me.SendPropertyChanging
				Me._SeqNo = value
				Me.SendPropertyChanged("SeqNo")
				Me.OnSeqNoChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_SubSeqNo", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property SubSeqNo() As Integer
		Get
			Return Me._SubSeqNo
		End Get
		Set
			If ((Me._SubSeqNo = value)  _
						= false) Then
				Me.OnSubSeqNoChanging(value)
				Me.SendPropertyChanging
				Me._SubSeqNo = value
				Me.SendPropertyChanged("SubSeqNo")
				Me.OnSubSeqNoChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_P1ImgSeqNo", DbType:="Int")>  _
	Public Property P1ImgSeqNo() As System.Nullable(Of Integer)
		Get
			Return Me._P1ImgSeqNo
		End Get
		Set
			If (Me._P1ImgSeqNo.Equals(value) = false) Then
				Me.OnP1ImgSeqNoChanging(value)
				Me.SendPropertyChanging
				Me._P1ImgSeqNo = value
				Me.SendPropertyChanged("P1ImgSeqNo")
				Me.OnP1ImgSeqNoChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_P2ImgSeqNo", DbType:="Int")>  _
	Public Property P2ImgSeqNo() As System.Nullable(Of Integer)
		Get
			Return Me._P2ImgSeqNo
		End Get
		Set
			If (Me._P2ImgSeqNo.Equals(value) = false) Then
				Me.OnP2ImgSeqNoChanging(value)
				Me.SendPropertyChanging
				Me._P2ImgSeqNo = value
				Me.SendPropertyChanged("P2ImgSeqNo")
				Me.OnP2ImgSeqNoChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ItemType", DbType:="Char(1) NOT NULL")>  _
	Public Property ItemType() As Char
		Get
			Return Me._ItemType
		End Get
		Set
			If ((Me._ItemType = value)  _
						= false) Then
				Me.OnItemTypeChanging(value)
				Me.SendPropertyChanging
				Me._ItemType = value
				Me.SendPropertyChanged("ItemType")
				Me.OnItemTypeChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_BatchType", DbType:="SmallInt NOT NULL")>  _
	Public Property BatchType() As Short
		Get
			Return Me._BatchType
		End Get
		Set
			If ((Me._BatchType = value)  _
						= false) Then
				Me.OnBatchTypeChanging(value)
				Me.SendPropertyChanging
				Me._BatchType = value
				Me.SendPropertyChanged("BatchType")
				Me.OnBatchTypeChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Amount", DbType:="Char(10)")>  _
	Public Property Amount() As String
		Get
			Return Me._Amount
		End Get
		Set
			If (String.Equals(Me._Amount, value) = false) Then
				Me.OnAmountChanging(value)
				Me.SendPropertyChanging
				Me._Amount = value
				Me.SendPropertyChanged("Amount")
				Me.OnAmountChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_UserString1", DbType:="Char(40)")>  _
	Public Property UserString1() As String
		Get
			Return Me._UserString1
		End Get
		Set
			If (String.Equals(Me._UserString1, value) = false) Then
				Me.OnUserString1Changing(value)
				Me.SendPropertyChanging
				Me._UserString1 = value
				Me.SendPropertyChanged("UserString1")
				Me.OnUserString1Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_UserString2", DbType:="VarChar(40)")>  _
	Public Property UserString2() As String
		Get
			Return Me._UserString2
		End Get
		Set
			If (String.Equals(Me._UserString2, value) = false) Then
				Me.OnUserString2Changing(value)
				Me.SendPropertyChanging
				Me._UserString2 = value
				Me.SendPropertyChanged("UserString2")
				Me.OnUserString2Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_UserString3", DbType:="VarChar(40)")>  _
	Public Property UserString3() As String
		Get
			Return Me._UserString3
		End Get
		Set
			If (String.Equals(Me._UserString3, value) = false) Then
				Me.OnUserString3Changing(value)
				Me.SendPropertyChanging
				Me._UserString3 = value
				Me.SendPropertyChanged("UserString3")
				Me.OnUserString3Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_UserString4", DbType:="VarChar(40)")>  _
	Public Property UserString4() As String
		Get
			Return Me._UserString4
		End Get
		Set
			If (String.Equals(Me._UserString4, value) = false) Then
				Me.OnUserString4Changing(value)
				Me.SendPropertyChanging
				Me._UserString4 = value
				Me.SendPropertyChanged("UserString4")
				Me.OnUserString4Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_UserString5", DbType:="VarChar(40)")>  _
	Public Property UserString5() As String
		Get
			Return Me._UserString5
		End Get
		Set
			If (String.Equals(Me._UserString5, value) = false) Then
				Me.OnUserString5Changing(value)
				Me.SendPropertyChanging
				Me._UserString5 = value
				Me.SendPropertyChanged("UserString5")
				Me.OnUserString5Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_UserString6", DbType:="VarChar(40)")>  _
	Public Property UserString6() As String
		Get
			Return Me._UserString6
		End Get
		Set
			If (String.Equals(Me._UserString6, value) = false) Then
				Me.OnUserString6Changing(value)
				Me.SendPropertyChanging
				Me._UserString6 = value
				Me.SendPropertyChanged("UserString6")
				Me.OnUserString6Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_UserString7", DbType:="VarChar(40)")>  _
	Public Property UserString7() As String
		Get
			Return Me._UserString7
		End Get
		Set
			If (String.Equals(Me._UserString7, value) = false) Then
				Me.OnUserString7Changing(value)
				Me.SendPropertyChanging
				Me._UserString7 = value
				Me.SendPropertyChanged("UserString7")
				Me.OnUserString7Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_UserString8", DbType:="VarChar(40)")>  _
	Public Property UserString8() As String
		Get
			Return Me._UserString8
		End Get
		Set
			If (String.Equals(Me._UserString8, value) = false) Then
				Me.OnUserString8Changing(value)
				Me.SendPropertyChanging
				Me._UserString8 = value
				Me.SendPropertyChanged("UserString8")
				Me.OnUserString8Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_UserField1", DbType:="VarChar(20)")>  _
	Public Property UserField1() As String
		Get
			Return Me._UserField1
		End Get
		Set
			If (String.Equals(Me._UserField1, value) = false) Then
				Me.OnUserField1Changing(value)
				Me.SendPropertyChanging
				Me._UserField1 = value
				Me.SendPropertyChanged("UserField1")
				Me.OnUserField1Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_UserField2", DbType:="VarChar(20)")>  _
	Public Property UserField2() As String
		Get
			Return Me._UserField2
		End Get
		Set
			If (String.Equals(Me._UserField2, value) = false) Then
				Me.OnUserField2Changing(value)
				Me.SendPropertyChanging
				Me._UserField2 = value
				Me.SendPropertyChanged("UserField2")
				Me.OnUserField2Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_UserInt1", DbType:="VarChar(5)")>  _
	Public Property UserInt1() As String
		Get
			Return Me._UserInt1
		End Get
		Set
			If (String.Equals(Me._UserInt1, value) = false) Then
				Me.OnUserInt1Changing(value)
				Me.SendPropertyChanging
				Me._UserInt1 = value
				Me.SendPropertyChanged("UserInt1")
				Me.OnUserInt1Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_UserInt2", DbType:="VarChar(4)")>  _
	Public Property UserInt2() As String
		Get
			Return Me._UserInt2
		End Get
		Set
			If (String.Equals(Me._UserInt2, value) = false) Then
				Me.OnUserInt2Changing(value)
				Me.SendPropertyChanging
				Me._UserInt2 = value
				Me.SendPropertyChanged("UserInt2")
				Me.OnUserInt2Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_UserInt3", DbType:="Int")>  _
	Public Property UserInt3() As System.Nullable(Of Integer)
		Get
			Return Me._UserInt3
		End Get
		Set
			If (Me._UserInt3.Equals(value) = false) Then
				Me.OnUserInt3Changing(value)
				Me.SendPropertyChanging
				Me._UserInt3 = value
				Me.SendPropertyChanged("UserInt3")
				Me.OnUserInt3Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_UserFlag1", DbType:="Char(1)")>  _
	Public Property UserFlag1() As System.Nullable(Of Char)
		Get
			Return Me._UserFlag1
		End Get
		Set
			If (Me._UserFlag1.Equals(value) = false) Then
				Me.OnUserFlag1Changing(value)
				Me.SendPropertyChanging
				Me._UserFlag1 = value
				Me.SendPropertyChanged("UserFlag1")
				Me.OnUserFlag1Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_UserFlag2", DbType:="Char(1)")>  _
	Public Property UserFlag2() As System.Nullable(Of Char)
		Get
			Return Me._UserFlag2
		End Get
		Set
			If (Me._UserFlag2.Equals(value) = false) Then
				Me.OnUserFlag2Changing(value)
				Me.SendPropertyChanging
				Me._UserFlag2 = value
				Me.SendPropertyChanged("UserFlag2")
				Me.OnUserFlag2Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_UserFlag3", DbType:="Char(1)")>  _
	Public Property UserFlag3() As System.Nullable(Of Char)
		Get
			Return Me._UserFlag3
		End Get
		Set
			If (Me._UserFlag3.Equals(value) = false) Then
				Me.OnUserFlag3Changing(value)
				Me.SendPropertyChanging
				Me._UserFlag3 = value
				Me.SendPropertyChanged("UserFlag3")
				Me.OnUserFlag3Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_Phone", DbType:="VarChar(50)")>  _
	Public Property Phone() As String
		Get
			Return Me._Phone
		End Get
		Set
			If (String.Equals(Me._Phone, value) = false) Then
				Me.OnPhoneChanging(value)
				Me.SendPropertyChanging
				Me._Phone = value
				Me.SendPropertyChanged("Phone")
				Me.OnPhoneChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Email", DbType:="VarChar(75)")>  _
	Public Property Email() As String
		Get
			Return Me._Email
		End Get
		Set
			If (String.Equals(Me._Email, value) = false) Then
				Me.OnEmailChanging(value)
				Me.SendPropertyChanging
				Me._Email = value
				Me.SendPropertyChanged("Email")
				Me.OnEmailChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_status", DbType:="Char(10)")>  _
	Public Property status() As String
		Get
			Return Me._status
		End Get
		Set
			If (String.Equals(Me._status, value) = false) Then
				Me.OnstatusChanging(value)
				Me.SendPropertyChanging
				Me._status = value
				Me.SendPropertyChanged("status")
				Me.OnstatusChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Table(Name:="dbo.Wrksrctbl")>  _
Partial Public Class Wrksrctbl
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _WorksrcNum As String
	
	Private _Name As String
	
	Private _ImagePath As String
	
	Private _XmlPath As String
	
	Private _AutoTrans As System.Nullable(Of Char)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnWorksrcNumChanging(value As String)
    End Sub
    Partial Private Sub OnWorksrcNumChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
    Partial Private Sub OnImagePathChanging(value As String)
    End Sub
    Partial Private Sub OnImagePathChanged()
    End Sub
    Partial Private Sub OnXmlPathChanging(value As String)
    End Sub
    Partial Private Sub OnXmlPathChanged()
    End Sub
    Partial Private Sub OnAutoTransChanging(value As System.Nullable(Of Char))
    End Sub
    Partial Private Sub OnAutoTransChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Column(Storage:="_WorksrcNum", DbType:="Char(10) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property WorksrcNum() As String
		Get
			Return Me._WorksrcNum
		End Get
		Set
			If (String.Equals(Me._WorksrcNum, value) = false) Then
				Me.OnWorksrcNumChanging(value)
				Me.SendPropertyChanging
				Me._WorksrcNum = value
				Me.SendPropertyChanged("WorksrcNum")
				Me.OnWorksrcNumChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Name", DbType:="Char(16) NOT NULL", CanBeNull:=false)>  _
	Public Property Name() As String
		Get
			Return Me._Name
		End Get
		Set
			If (String.Equals(Me._Name, value) = false) Then
				Me.OnNameChanging(value)
				Me.SendPropertyChanging
				Me._Name = value
				Me.SendPropertyChanged("Name")
				Me.OnNameChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ImagePath", DbType:="Char(60)")>  _
	Public Property ImagePath() As String
		Get
			Return Me._ImagePath
		End Get
		Set
			If (String.Equals(Me._ImagePath, value) = false) Then
				Me.OnImagePathChanging(value)
				Me.SendPropertyChanging
				Me._ImagePath = value
				Me.SendPropertyChanged("ImagePath")
				Me.OnImagePathChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_XmlPath", DbType:="Char(60)")>  _
	Public Property XmlPath() As String
		Get
			Return Me._XmlPath
		End Get
		Set
			If (String.Equals(Me._XmlPath, value) = false) Then
				Me.OnXmlPathChanging(value)
				Me.SendPropertyChanging
				Me._XmlPath = value
				Me.SendPropertyChanged("XmlPath")
				Me.OnXmlPathChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_AutoTrans", DbType:="Char(1)")>  _
	Public Property AutoTrans() As System.Nullable(Of Char)
		Get
			Return Me._AutoTrans
		End Get
		Set
			If (Me._AutoTrans.Equals(value) = false) Then
				Me.OnAutoTransChanging(value)
				Me.SendPropertyChanging
				Me._AutoTrans = value
				Me.SendPropertyChanged("AutoTrans")
				Me.OnAutoTransChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
