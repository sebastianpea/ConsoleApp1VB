Public Class Archivos
  ''Metodo para almacenar en un archivo de texto la información de los docentes
  Public Shared Sub GuardarDocentes(docentes As List(Of Docente), rutaArchivo As String)
    Using writer As New System.IO.StreamWriter(rutaArchivo)
      For Each docente As Docente In docentes
        writer.WriteLine(docente.ToString())
      Next
    End Using
  End Sub
  '' Metodo para importar la información de los docentes desde un archivo de texto
  Public Shared Function ImportarDocentes(rutaArchivo As String) As List(Of Docente)
    Dim docentes As New List(Of Docente)()
    If System.IO.File.Exists(rutaArchivo) Then
      Using reader As New System.IO.StreamReader(rutaArchivo)
        While Not reader.EndOfStream
          Dim linea As String = reader.ReadLine()
          ' Aquí puedes implementar la lógica para convertir la línea de texto en un objeto Docente
          ' Por ejemplo, si la línea tiene el formato "ID: 1, Nombre: Juan, Apellidos: Pérez, Teléfono: 1234567890, Especialidad: Matemáticas, Materia: Álgebra"
          Dim partes As String() = linea.Split(New String() {", "}, StringSplitOptions.None)
          If partes.Length >= 6 Then
            Dim id As Integer = Convert.ToInt32(partes(0).Replace("ID: ", ""))
            Dim nombre As String = partes(1).Replace("Nombre: ", "")
            Dim apellidos As String = partes(2).Replace("Apellidos: ", "")
            Dim telefono As String = partes(3).Replace("Teléfono: ", "")
            Dim especialidad As String = partes(4).Replace("Especialidad: ", "")
            Dim materia As String = partes(5).Replace("Materia: ", "")
            docentes.Add(New Docente(id, nombre, apellidos, telefono, especialidad, materia))
          End If
        End While
      End Using
    End If
    Return docentes
  End Function
End Class
