﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Namespace MontagneAdministracion

    Partial Public Class VistaOrdCompras
        Inherits XPLiteObject
        Dim fIdOrdenCompra As Integer
        <Key()>
        Public Property IdOrdenCompra() As Integer
            Get
                Return fIdOrdenCompra
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("IdOrdenCompra", fIdOrdenCompra, value)
            End Set
        End Property
        Dim fIdPedido As Integer
        Public Property IdPedido() As Integer
            Get
                Return fIdPedido
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("IdPedido", fIdPedido, value)
            End Set
        End Property
        Dim fFechaCompra As DateTime
        Public Property FechaCompra() As DateTime
            Get
                Return fFechaCompra
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("FechaCompra", fFechaCompra, value)
            End Set
        End Property
        Dim fRazonSocial As String
        <Size(80)>
        Public Property RazonSocial() As String
            Get
                Return fRazonSocial
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("RazonSocial", fRazonSocial, value)
            End Set
        End Property
    End Class

End Namespace
