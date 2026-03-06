Public Class Persona
  ' Atributos
  Private _nombre As String
  Private _id As Integer
  Private _apellidos As String
  Private _telefono As String
  'Propiedades
  Public Property Id As Integer
    Get
      Return _id
    End Get
    Set(value As Integer)
      _id = value
    End Set
  End Property
  Public Property Nombre As String
    Get
      Return _nombre
    End Get
    Set(value As String)
      _nombre = value
    End Set
  End Property
  Public Property Apellidos As String
    Get
      Return _apellidos
    End Get
    Set(value As String)
      _apellidos = value
    End Set
  End Property
  Public Property Telefono As String
    Get
      Return _telefono
    End Get
    Set(value As String)
      _telefono = value
    End Set
  End Property
  'Constructores  
  Public Sub New()
    ''Inicializar los atributos con valores por defecto
    _id = 0
    _nombre = String.Empty
    _apellidos = String.Empty
    _telefono = String.Empty
  End Sub
  Public Sub New(id As Integer, nombre As String, apellidos As String, telefono As String)
    _id = id
    _nombre = nombre
    _apellidos = apellidos
    _telefono = telefono
  End Sub
  ''Métodos
  Public Overrides Function ToString() As String
    Return $"ID: {_id}, Nombre: {_nombre}, Apellidos: {_apellidos}, Teléfono: {_telefono}"
  End Function
End Class
