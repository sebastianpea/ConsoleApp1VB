Public Class Docente
  Inherits Persona
  ' Atributos específicos de Docente
  Private _especialidad As String
  Private _materia As String
  ' Propiedades
  Public Property Especialidad As String
    Get
      Return _especialidad
    End Get
    Set(value As String)
      _especialidad = value
    End Set
  End Property
  Public Property Materia As String
    Get
      Return _materia
    End Get
    Set(value As String)
      _materia = value
    End Set
  End Property
  ' Constructores  
  Public Sub New()
    MyBase.New() ' Llamada al constructor de la clase base (Persona)
    ''Inicializar los atributos específicos de Docente con valores por defecto
    _especialidad = String.Empty
    _materia = String.Empty
  End Sub
  Public Sub New(id As Integer, nombre As String, apellidos As String, telefono As String, departamento As String, titulo As String)
    MyBase.New(id, nombre, apellidos, telefono) ' Llamada al constructor de la clase base (Persona)
    _especialidad = departamento
    _materia = titulo
  End Sub
  ''Métodos específicos de Docente (si es necesario)
  Public Overrides Function ToString() As String
    Return $"{MyBase.ToString()}, Especialidad: {_especialidad}, Materia: {_materia}"
  End Function

End Class
