'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class celularesproEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=celularesproEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property celular() As DbSet(Of celular)
    Public Overridable Property cliente() As DbSet(Of cliente)
    Public Overridable Property detallepedido() As DbSet(Of detallepedido)
    Public Overridable Property pago() As DbSet(Of pago)
    Public Overridable Property pedido() As DbSet(Of pedido)
    Public Overridable Property database_firewall_rules() As DbSet(Of database_firewall_rules)
    Public Overridable Property ipv6_database_firewall_rules() As DbSet(Of ipv6_database_firewall_rules)

    Public Overridable Function cliepago() As ObjectResult(Of cliepago_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of cliepago_Result)("cliepago")
    End Function

    Public Overridable Function clieped() As ObjectResult(Of clieped_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of clieped_Result)("clieped")
    End Function

    Public Overridable Function deletecel(id As Nullable(Of Integer)) As Integer
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("deletecel", idParameter)
    End Function

    Public Overridable Function deletecliente(id As Nullable(Of Integer)) As Integer
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("deletecliente", idParameter)
    End Function

    Public Overridable Function insertarcel(nom As String, caract As String, model As String, prec As Nullable(Of Decimal), cantidad As Nullable(Of Integer)) As Integer
        Dim nomParameter As ObjectParameter = If(nom IsNot Nothing, New ObjectParameter("nom", nom), New ObjectParameter("nom", GetType(String)))

        Dim caractParameter As ObjectParameter = If(caract IsNot Nothing, New ObjectParameter("caract", caract), New ObjectParameter("caract", GetType(String)))

        Dim modelParameter As ObjectParameter = If(model IsNot Nothing, New ObjectParameter("model", model), New ObjectParameter("model", GetType(String)))

        Dim precParameter As ObjectParameter = If(prec.HasValue, New ObjectParameter("prec", prec), New ObjectParameter("prec", GetType(Decimal)))

        Dim cantidadParameter As ObjectParameter = If(cantidad.HasValue, New ObjectParameter("cantidad", cantidad), New ObjectParameter("cantidad", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("insertarcel", nomParameter, caractParameter, modelParameter, precParameter, cantidadParameter)
    End Function

    Public Overridable Function insertarcliente(nom As String, edad As Nullable(Of Integer), dir As String, tel As String) As Integer
        Dim nomParameter As ObjectParameter = If(nom IsNot Nothing, New ObjectParameter("nom", nom), New ObjectParameter("nom", GetType(String)))

        Dim edadParameter As ObjectParameter = If(edad.HasValue, New ObjectParameter("edad", edad), New ObjectParameter("edad", GetType(Integer)))

        Dim dirParameter As ObjectParameter = If(dir IsNot Nothing, New ObjectParameter("dir", dir), New ObjectParameter("dir", GetType(String)))

        Dim telParameter As ObjectParameter = If(tel IsNot Nothing, New ObjectParameter("tel", tel), New ObjectParameter("tel", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("insertarcliente", nomParameter, edadParameter, dirParameter, telParameter)
    End Function

    Public Overridable Function pagoped() As ObjectResult(Of pagoped_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of pagoped_Result)("pagoped")
    End Function

    Public Overridable Function pedidodet() As ObjectResult(Of pedidodet_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of pedidodet_Result)("pedidodet")
    End Function

    Public Overridable Function upcel(id As Nullable(Of Integer), nom As String, caract As String, model As String, prec As Nullable(Of Decimal), cantidad As Nullable(Of Integer)) As Integer
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Dim nomParameter As ObjectParameter = If(nom IsNot Nothing, New ObjectParameter("nom", nom), New ObjectParameter("nom", GetType(String)))

        Dim caractParameter As ObjectParameter = If(caract IsNot Nothing, New ObjectParameter("caract", caract), New ObjectParameter("caract", GetType(String)))

        Dim modelParameter As ObjectParameter = If(model IsNot Nothing, New ObjectParameter("model", model), New ObjectParameter("model", GetType(String)))

        Dim precParameter As ObjectParameter = If(prec.HasValue, New ObjectParameter("prec", prec), New ObjectParameter("prec", GetType(Decimal)))

        Dim cantidadParameter As ObjectParameter = If(cantidad.HasValue, New ObjectParameter("cantidad", cantidad), New ObjectParameter("cantidad", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("upcel", idParameter, nomParameter, caractParameter, modelParameter, precParameter, cantidadParameter)
    End Function

    Public Overridable Function upclie(id As Nullable(Of Integer), nom As String, edad As Nullable(Of Integer), dir As String, tel As String) As Integer
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Dim nomParameter As ObjectParameter = If(nom IsNot Nothing, New ObjectParameter("nom", nom), New ObjectParameter("nom", GetType(String)))

        Dim edadParameter As ObjectParameter = If(edad.HasValue, New ObjectParameter("edad", edad), New ObjectParameter("edad", GetType(Integer)))

        Dim dirParameter As ObjectParameter = If(dir IsNot Nothing, New ObjectParameter("dir", dir), New ObjectParameter("dir", GetType(String)))

        Dim telParameter As ObjectParameter = If(tel IsNot Nothing, New ObjectParameter("tel", tel), New ObjectParameter("tel", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("upclie", idParameter, nomParameter, edadParameter, dirParameter, telParameter)
    End Function

End Class
