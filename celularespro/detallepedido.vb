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

Partial Public Class detallepedido
    Public Property id_detallepedido As Integer
    Public Property id_celular As Integer
    Public Property id_cliente As Integer
    Public Property precio As Nullable(Of Decimal)
    Public Property cantidad As Nullable(Of Integer)

    Public Overridable Property celular As celular
    Public Overridable Property cliente As cliente
    Public Overridable Property pedido As ICollection(Of pedido) = New HashSet(Of pedido)

End Class
