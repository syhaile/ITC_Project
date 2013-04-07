Public Class Controller
    Private ctrlCourseDB As New CoursesDatabase
    Private ctrlStudentDB As New StudentDatabase
    Private ctrlTeacherDB As New TeacherDatabase
    Private ctrlRoomDB As New RoomDatabase
    Private ctrlScheduleDB As New ScheduleDatabase

    Public Sub addCourse(ByVal course As Course)
        ctrlCourseDB.addCourse(course)
    End Sub

    Public Function getAllCourses() As ArrayList
        Return ctrlCourseDB.getAllCourses()
    End Function

    Public Function getCourseDB()
        Return ctrlCourseDB.MasterDatabase
    End Function

    Public Function getStudentDB()
        Return ctrlStudentDB.MasterDatabase
    End Function

    Public Function getTeacherDB()
        Return ctrlTeacherDB.MasterDatabase
    End Function

    Public Function getRoomDB()
        Return ctrlRoomDB.MasterDatabase
    End Function

    Public Function getScheduleDB()
        Return ctrlScheduleDB.MasterDatabase
    End Function


End Class
