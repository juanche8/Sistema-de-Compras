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

    Partial Public Class Sectores
        Inherits XPLiteObject
        Dim fIdSector As Integer
        <Key(True)>
        Public Property IdSector() As Integer
            Get
                Return fIdSector
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("IdSector", fIdSector, value)
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
