'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class cliente
    Public Property id_cliente As Integer
    Public Property nombre As String
    Public Property edad As Nullable(Of Integer)
    Public Property direccion As String
    Public Property telefono As String

    Public Overridable Property detallepedido As ICollection(Of detallepedido) = New HashSet(Of detallepedido)
    Public Overridable Property pago As ICollection(Of pago) = New HashSet(Of pago)

End Class