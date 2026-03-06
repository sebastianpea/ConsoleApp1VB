Imports System
Imports System.IO
Module Program
  Sub Main(args As String())
    ''Crear la Lista de Alumnos y la Lista de Docentes

    Dim docentes As New List(Of Docente)()
    Dim alumnos As New List(Of Alumno)()
        ''Cargar los docentes del archivo de texto al iniciar el programa
        '' si el archivo existe, importar los docentes desde el archivo de texto
        If File.Exists("docentes.txt") Then
            docentes = Archivos.ImportarDocentes("docentes.txt")
        End If

        If File.Exists("alumnos.txt") Then
            alumnos = Archivos.ImportarAlumnos("alumnos.txt")
        End If

        ' Crear menu para escojer entre docentes y alumnos y depende del seleccionado mostrar un CRUD para cada uno
        Dim opcion As Integer
    Do

      Console.WriteLine("1. Gestionar Docentes")
      Console.WriteLine("2. Gestionar Alumnos")
      Console.WriteLine("3. Salir")
      Console.Write("Ingrese su opción:")
      opcion = Convert.ToInt32(Console.ReadLine())
      Select Case opcion
        Case 1
          ' Lógica para gestionar docentes (CRUD)
          Console.WriteLine("Gestión de Docentes")
          ' Aquí puedes implementar las opciones para agregar, editar, eliminar y mostrar docentes
          ''Mostrar el menu para gestionar docentes

          Console.WriteLine("1. Agregar Docente")
          Console.WriteLine("2. Editar Docente")
          Console.WriteLine("3. Eliminar Docente")
          Console.WriteLine("4. Mostrar Docentes")
          Console.WriteLine("5. Almacenar en Archivo")
          Console.Write("Ingrese su opción:")
          Dim opcionDocente As Integer
          opcionDocente = Convert.ToInt32(Console.ReadLine())
          Select Case opcionDocente
            Case 1
              Console.WriteLine("Agregar Docente")
              ' Aquí puedes implementar la lógica para agregar un docente
              ''Pedir los datos del docente y almacenarlos en la lista de docentes
              Dim nuevoDocente As New Docente()
              Console.Write("Ingrese el ID del docente:")
              nuevoDocente.Id = Convert.ToInt32(Console.ReadLine())
              Console.Write("Ingrese el nombre del docente:")
              nuevoDocente.Nombre = Console.ReadLine()
              Console.Write("Ingrese los apellidos del docente:")
              nuevoDocente.Apellidos = Console.ReadLine()
              Console.Write("Ingrese el teléfono del docente:")
              nuevoDocente.Telefono = Console.ReadLine()
              Console.Write("Ingrese la especialidad del docente:")
              nuevoDocente.Especialidad = Console.ReadLine()
              Console.Write("Ingrese la materia del docente:")
                            nuevoDocente.Materia = Console.ReadLine()
                            Dim idExisteDocente As Docente = docentes.Find(Function(a) a.Id = nuevoDocente.Id)
                            If idExisteDocente IsNot Nothing Then
                                Console.WriteLine("Error: Ya existe un docente con ese ID. No se puede agregar.")
                                Continue Do
                            End If
                            docentes.Add(nuevoDocente)

                        Case 2
              Console.WriteLine("Editar Docente")
              ' Aquí puedes implementar la lógica para editar un docente
              ''Pedir el ID del docente a editar y actualizar sus datos
              Console.WriteLine("Ingrese el ID del docente a editar:")
              Dim idEditar As Integer
              idEditar = Convert.ToInt32(Console.ReadLine())
              Dim docenteEditar As Docente = docentes.Find(Function(d) d.Id = idEditar)
              If docenteEditar IsNot Nothing Then
                Console.WriteLine("Ingrese el nuevo nombre del docente:")
                docenteEditar.Nombre = Console.ReadLine()
                Console.WriteLine("Ingrese los nuevos apellidos del docente:")
                docenteEditar.Apellidos = Console.ReadLine()
                Console.WriteLine("Ingrese el nuevo teléfono del docente:")
                docenteEditar.Telefono = Console.ReadLine()
                Console.WriteLine("Ingrese la nueva especialidad del docente:")
                docenteEditar.Especialidad = Console.ReadLine()
                Console.WriteLine("Ingrese la nueva materia del docente:")
                docenteEditar.Materia = Console.ReadLine()
              Else
                Console.WriteLine("Docente no encontrado.")
              End If
            Case 3
              Console.WriteLine("Eliminar Docente")
              ' Aquí puedes implementar la lógica para eliminar un docente
              ''Pedir el ID del docente a eliminar y eliminarlo de la lista de docentes
              Console.WriteLine("Ingrese el ID del docente a eliminar:")
              Dim idEliminar As Integer
              idEliminar = Convert.ToInt32(Console.ReadLine())
              Dim docenteEliminar As Docente = docentes.Find(Function(d) d.Id = idEliminar)
              If docenteEliminar IsNot Nothing Then
                docentes.Remove(docenteEliminar)
                Console.WriteLine("Docente eliminado.")
              Else
                Console.WriteLine("Docente no encontrado.")
              End If
            Case 4
              Console.WriteLine("Mostrar Docentes")
              ' Aquí puedes implementar la lógica para mostrar los docentes
              For Each docente As Docente In docentes
                Console.WriteLine(docente.ToString())
              Next
              Console.WriteLine("Pulsa una tecla para continuar ...")
              Console.ReadKey()
            Case 5
              Console.WriteLine("Almacenar en Archivo")
              ' Aquí puedes implementar la lógica para almacenar los docentes en un archivo de texto
              Archivos.GuardarDocentes(docentes, "docentes.txt")
              Console.WriteLine("Docentes almacenados en el archivo 'docentes.txt'.")
            Case Else
              Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.")
          End Select
                Case 2
                    Console.WriteLine("Gestión de Alumnos")
                    Console.WriteLine("1. Agregar Alumno")
                    Console.WriteLine("2. Editar Alumno")
                    Console.WriteLine("3. Eliminar Alumno")
                    Console.WriteLine("4. Mostrar Alumnos")
                    Console.WriteLine("5. Almacenar en Archivo")
                    Console.Write("Ingrese su opción:")
                    Dim opcionAlumno As Integer
                    opcionAlumno = Convert.ToInt32(Console.ReadLine())

                    Select Case opcionAlumno
                        Case 1
                            Console.WriteLine("Agregar Alumno")
                            ' Aquí puedes implementar la lógica para agregar un alumno
                            ''Pedir los datos del alumno y almacenarlos en la lista de alumnos
                            Dim nuevoAlumno As New Alumno()
                            Console.Write("Ingrese el ID del alumno:")
                            nuevoAlumno.Id = Convert.ToInt32(Console.ReadLine())
                            Console.Write("Ingrese el nombre del alumno:")
                            nuevoAlumno.Nombre = Console.ReadLine()
                            Console.Write("Ingrese los apellidos del alumno:")
                            nuevoAlumno.Apellidos = Console.ReadLine()
                            Console.Write("Ingrese el teléfono del alumno:")
                            nuevoAlumno.Telefono = Console.ReadLine()
                            Console.Write("Ingrese la especialidad del alumno:")
                            nuevoAlumno.Especialidad = Console.ReadLine()
                            Console.Write("Ingrese la matrícula del alumno:")
                            nuevoAlumno.Matricula = Console.ReadLine()
                            Dim idExisteAlumno As Alumno = alumnos.Find(Function(a) a.Id = nuevoAlumno.Id)
                            If idExisteAlumno IsNot Nothing Then
                                Console.WriteLine("Ya existe un alumno con ese ID. No se puede agregar.")
                                Continue Do
                            End If
                            alumnos.Add(nuevoAlumno)

                        Case 2
                            Console.WriteLine("Editar Alumno")
                            ' Aquí puedes implementar la lógica para editar un alumno
                            ''Pedir el ID del alumno a editar y actualizar sus datos
                            Console.WriteLine("Ingrese el ID del alumno a editar:")
                            Dim idEditar As Integer
                            idEditar = Convert.ToInt32(Console.ReadLine())
                            Dim alumnoEditar As Alumno = alumnos.Find(Function(a) a.Id = idEditar)
                            If alumnoEditar IsNot Nothing Then
                                Console.WriteLine("Ingrese el nuevo nombre del alumno:")
                                alumnoEditar.Nombre = Console.ReadLine()
                                Console.WriteLine("Ingrese los nuevos apellidos del alumno:")
                                alumnoEditar.Apellidos = Console.ReadLine()
                                Console.WriteLine("Ingrese el nuevo teléfono del alumno:")
                                alumnoEditar.Telefono = Console.ReadLine()
                                Console.WriteLine("Ingrese la nueva especialidad del alumno:")
                                alumnoEditar.Especialidad = Console.ReadLine()
                                Console.WriteLine("Ingrese la nueva matrícula del alumno:")
                                alumnoEditar.Matricula = Console.ReadLine()
                            Else
                                Console.WriteLine("Alumno no encontrado.")


                            End If

                        Case 3
                            Console.WriteLine("Eliminar Alumno")
                            ' Aquí puedes implementar la lógica para eliminar un alumno
                            ''Pedir el ID del alumno a eliminar y eliminarlo de la lista de alumnos
                            Console.WriteLine("Ingrese el ID del alumno a eliminar:")
                            Dim idEliminar As Integer
                            idEliminar = Convert.ToInt32(Console.ReadLine())
                            Dim alumnoEliminar As Alumno = alumnos.Find(Function(a) a.Id = idEliminar)
                            If alumnoEliminar IsNot Nothing Then
                                alumnos.Remove(alumnoEliminar)
                                Console.WriteLine("Alumno eliminado.")
                            Else
                                Console.WriteLine("Alumno no encontrado.")
                            End If

                        Case 4
                            Console.WriteLine("Mostrar Alumnos")
                            ' Aquí puedes implementar la lógica para mostrar los alumnos
                            For Each alumno As Alumno In alumnos
                                Console.WriteLine(alumno.ToString())
                            Next
                            Console.WriteLine("Pulsa una tecla para continuar ...")
                            Console.ReadKey()

                        Case 5
                            Console.WriteLine("Almacenar en Archivo")

                            Archivos.GuardarAlumnos(alumnos, "alumnos.txt") ' Implementa este método en la clase Archivos
                            ' Aquí puedes implementar la lógica para almacenar los alumnos en un archivo de texto
                            ' Archivos.GuardarAlumnos(alumnos, "alumnos.txt") ' Implementa este método en la clase Archivos
                            Console.WriteLine("Alumnos almacenados en el archivo 'alumnos.txt'.")

                    End Select
                Case 3
                    Console.WriteLine("Saliendo del programa...")

                    Environment.Exit(0)
                Case Else
          Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.")
      End Select
      Console.Clear()
    Loop While opcion <> 3

  End Sub

End Module
