Public Class Alumno
  Inherits Persona
  ' Atributos específicos de Alumno
  Private _especialidad As String
  Private _matricula As String
  ' Propiedades
  Public Property Especialidad As String
    Get
      Return _especialidad
    End Get
    Set(value As String)
      _especialidad = value
    End Set
  End Property
  Public Property Matricula As String
    Get
      Return _matricula
    End Get
    Set(value As String)
      _matricula = value
    End Set
  End Property
  ' Constructores  
  Public Sub New()
    MyBase.New() ' Llamada al constructor de la clase base (Persona)
    ''Inicializar los atributos específicos de Alumno con valores por defecto
    _especialidad = String.Empty
    _matricula = String.Empty
  End Sub
  Public Sub New(id As Integer, nombre As String, apellidos As String, telefono As String, especialidad As String, matricula As String)
    MyBase.New(id, nombre, apellidos, telefono) ' Llamada al constructor de la clase base (Persona)
    _especialidad = especialidad
    _matricula = matricula
  End Sub
  ''Métodos específicos de Alumno (si es necesario)
  Public Overrides Function ToString() As String
    Return $"{MyBase.ToString()}, Especialidad: {_especialidad}, Matrícula: {_matricula}"
  End Function
End Class
