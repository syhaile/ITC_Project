''' <summary>
''' A schedule keeps track of all courses offered in a quarter.
''' </summary>
''' <remarks>TODO:
''' - code cleanup and documentation
''' - validation rules for adding into schedule</remarks>
Public Class Schedule
    'This class contains all sections in a schedule
    Private m_sectionCollection As New Collection
    Private m_year As Integer
    Private m_quarter As String
    Private m_scheduleID As String

    Public Sub New(ByVal id As String)
        'pull data from sql db to generate schedule
        Dim ds As New DataSet
        Dim ta As New KSUDBDataSetTableAdapters.ClassScheduleTableAdapter
        ds.Tables.Add(ta.GetScheduleDataByID(id))
        Me.ScheduleID = ds.Tables(0).Rows(0).Item("scheduleID")
        Me.Year = ds.Tables(0).Rows(0).Item("year")
        Me.Quarter = ds.Tables(0).Rows(0).Item("quarter")
        'add sections to section collection
        Dim ta2 As New KSUDBDataSetTableAdapters.SectionTableAdapter
        ds.Tables.Add(ta2.GetSectionDataByScheduleID(id))
        For Each row As DataRow In ds.Tables(1).Rows
            addSection(New Section(row("sectionID")))
        Next
        
    End Sub

    Public Sub New(ByVal id As String, ByVal year As String, ByVal quarter As String)
        Me.ScheduleID = id
        Me.Year = year
        Me.Quarter = quarter
    End Sub

    Public Property SectionCollection As Collection
        Get
            Return m_sectionCollection
        End Get
        Set(ByVal value As Collection)
            m_sectionCollection = value
        End Set
    End Property

    Public Property ScheduleID() As String
        Get
            Return m_scheduleID
        End Get
        Set(ByVal value As String)
            m_scheduleID = value
        End Set
    End Property

    Public Property Year() As Integer
        Get
            Return m_year
        End Get
        Set(ByVal value As Integer)
            m_year = value
        End Set
    End Property


    Public Property Quarter() As String
        Get
            Return m_quarter
        End Get
        Set(ByVal value As String)
            m_quarter = value
        End Set
    End Property


    Public Sub addSection(ByVal section As Section)
        m_sectionCollection.Add(section, section.SectionID)
    End Sub

    Public Function getSection(ByVal ID As String)
        Return m_sectionCollection.Item(ID)
    End Function

    Public Function getAllSections() As ArrayList
        Dim list As New ArrayList
        Dim schedule As Section
        For Each schedule In m_sectionCollection
            list.Add(schedule)
        Next
        Return list
    End Function
End Class
