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

    Partial Public Class Permisos
        Inherits XPLiteObject
        Dim fId As Integer
        <Key(True)>
        Public Property Id() As Integer
            Get
                Return fId
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("Id", fId, value)
            End Set
        End Property
        Dim fIdRol As Integer
        Public Property IdRol() As Integer
            Get
                Return fIdRol
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("IdRol", fIdRol, value)
            End Set
        End Property
        Dim fPermiso As String
        <Size(1)>
        Public Property Permiso() As String
            Get
                Return fPermiso
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Permiso", fPermiso, value)
            End Set
        End Property
        Dim fIdObjeto As Integer
        Public Property IdObjeto() As Integer
            Get
                Return fIdObjeto
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("IdObjeto", fIdObjeto, value)
            End Set
        End Property
    End Class

End Namespace
