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

    Partial Public Class ContactosProveedores
        Inherits XPLiteObject
        Dim fIdContacto As Integer
        <Key(True)>
        Public Property IdContacto() As Integer
            Get
                Return fIdContacto
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("IdContacto", fIdContacto, value)
            End Set
        End Property
        Dim fIdproveedor As Integer
        Public Property Idproveedor() As Integer
            Get
                Return fIdproveedor
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("Idproveedor", fIdproveedor, value)
            End Set
        End Property
        Dim fApellidos As String
        <Size(255)>
        Public Property Apellidos() As String
            Get
                Return fApellidos
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Apellidos", fApellidos, value)
            End Set
        End Property
        Dim fNombres As String
        <Size(255)>
        Public Property Nombres() As String
            Get
                Return fNombres
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Nombres", fNombres, value)
            End Set
        End Property
        Dim fSector_Oficina As String
        <Size(80)>
        Public Property Sector_Oficina() As String
            Get
                Return fSector_Oficina
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Sector_Oficina", fSector_Oficina, value)
            End Set
        End Property
        Dim fTelefonos As String
        <Size(255)>
        Public Property Telefonos() As String
            Get
                Return fTelefonos
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Telefonos", fTelefonos, value)
            End Set
        End Property
        Dim fEmail As String
        <Size(255)>
        Public Property Email() As String
            Get
                Return fEmail
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Email", fEmail, value)
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
    End Class

End Namespace
