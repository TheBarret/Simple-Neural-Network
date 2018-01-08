Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Module Extensions
    <System.Runtime.CompilerServices.Extension>
    Public Function Serialize(instance As Simple) As Byte()
        If (instance.GetType.IsSerializable) Then
            Dim ms As New MemoryStream
            Call New BinaryFormatter().Serialize(ms, instance)
            ms.Position = 0
            Return ms.ToArray
        End If
        Throw New Exception("instance cannot be serialized")
    End Function
    <System.Runtime.CompilerServices.Extension>
    Public Function Deserialize(Of T As Simple)(buffer() As Byte) As T
        If (buffer.Length > 0) Then
            Return CType(New BinaryFormatter().Deserialize(New MemoryStream(buffer)), T)
        End If
        Throw New IOException("no stream")
    End Function
    <System.Runtime.CompilerServices.Extension>
    Public Sub SaveAs(src As Byte(), filename As String, Optional Overwrite As Boolean = False)
        If (src IsNot Nothing) Then
            If (File.Exists(filename) AndAlso Overwrite) Then File.Delete(filename)
            Using bw As New BinaryWriter(File.Open(filename, FileMode.OpenOrCreate))
                bw.Write(src)
            End Using
        End If
    End Sub
End Module
