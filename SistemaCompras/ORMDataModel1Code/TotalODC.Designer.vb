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

    Partial Public Class TotalODC
        Inherits XPLiteObject
        Dim fIdPedido As Integer
        Public Property IdPedido() As Integer
            Get
                Return fIdPedido
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("IdPedido", fIdPedido, value)
            End Set
        End Property
        Dim fResponsable As String
        <Size(200)>
        Public Property Responsable() As String
            Get
                Return fResponsable
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Responsable", fResponsable, value)
            End Set
        End Property
        Dim fFechaPedido As DateTime
        Public Property FechaPedido() As DateTime
            Get
                Return fFechaPedido
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("FechaPedido", fFechaPedido, value)
            End Set
        End Property
        Dim fObservaciones As String
        <Size(SizeAttribute.Unlimited)>
        Public Property Observaciones() As String
            Get
                Return fObservaciones
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Observaciones", fObservaciones, value)
            End Set
        End Property
        Dim fFechaRecepcion As DateTime
        Public Property FechaRecepcion() As DateTime
            Get
                Return fFechaRecepcion
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("FechaRecepcion", fFechaRecepcion, value)
            End Set
        End Property
        Dim fAutorizadoPor As String
        <Size(255)>
        Public Property AutorizadoPor() As String
            Get
                Return fAutorizadoPor
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("AutorizadoPor", fAutorizadoPor, value)
            End Set
        End Property
        Dim fFechaAprobacion As DateTime
        Public Property FechaAprobacion() As DateTime
            Get
                Return fFechaAprobacion
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("FechaAprobacion", fFechaAprobacion, value)
            End Set
        End Property
        Dim fAproboMartin As Integer
        Public Property AproboMartin() As Integer
            Get
                Return fAproboMartin
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("AproboMartin", fAproboMartin, value)
            End Set
        End Property
        Dim fNombreProyecto As String
        <Size(255)>
        Public Property NombreProyecto() As String
            Get
                Return fNombreProyecto
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("NombreProyecto", fNombreProyecto, value)
            End Set
        End Property
        Dim fSector As String
        <Size(80)>
        Public Property Sector() As String
            Get
                Return fSector
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Sector", fSector, value)
            End Set
        End Property
        Dim ftotal As Decimal
        Public Property total() As Decimal
            Get
                Return ftotal
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("total", ftotal, value)
            End Set
        End Property
        Dim fRow As Long
        <Key()>
        Public Property Row() As Long
            Get
                Return fRow
            End Get
            Set(ByVal value As Long)
                SetPropertyValue(Of Long)("Row", fRow, value)
            End Set
        End Property
    End Class

End Namespace
