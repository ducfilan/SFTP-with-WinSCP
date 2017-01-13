Imports System.Reflection

Namespace Base
    Public MustInherit Class SingletonBase(Of T As SingletonBase(Of T))
        Private Shared ReadOnly _instance As Lazy(Of T)

        Public Shared ReadOnly Property Instance() As T
            Get
                Return _instance.Value
            End Get
        End Property

        Shared Sub New()
            _instance = New Lazy(Of T)(AddressOf InstanceFactory)
        End Sub

        Private Shared Function InstanceFactory() As T
            Dim type = GetType(T)
            Dim constructors = type.GetConstructors(BindingFlags.Instance Or BindingFlags.[Public] Or BindingFlags.NonPublic)

            If constructors.Length <> 1 Then
                Throw New TypeInitializationException(type.FullName, New TypeAccessException("Type must contain a single (non-public) constructor if derived from SingletonBase<T>."))
            End If

            Dim ctor = type.GetConstructor(BindingFlags.Instance Or BindingFlags.NonPublic, Nothing, Type.EmptyTypes, Nothing)

            If (ctor Is Nothing) OrElse (Not ctor.IsPrivate AndAlso Not ctor.IsFamily) Then
                Throw New TypeInitializationException(type.FullName, New TypeAccessException("Type must contain a single (non-public) constructor if derived from SingletonBase<T>."))
            End If

            Dim instance = TryCast(ctor.Invoke(New Object() {}), T)

            If instance Is Nothing Then
                Throw New TypeInitializationException(type.FullName, New NullReferenceException())
            End If

            Return instance
        End Function
    End Class
End Namespace