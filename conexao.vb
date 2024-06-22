Imports System.IO
Module conexao
    Dim x As Integer
    Private aConexao As New ADODB.Connection
    Private aconexao2 As New ADODB.Connection

    Dim acess_server, acess_db, acess_usr, acess_pwd


    Public Function OpenRecordset(ByVal sqlquery As String)

again:

        
        acess_server = "(local)"
       
        

        '   acess_db = "dbSoftClinica"

        Dim aResultado As New ADODB.Recordset
        '        acess_server = "servidor"

        acess_db = "dbAulanoite"
        acess_usr = "usrAula"
        acess_pwd = "1234"

       

        If aConexao.State = 0 Then

            aConexao.ConnectionString = "driver={sql server};" & _
                                            "server=" + acess_server + ";" & _
                                            "Database=" + acess_db + ";" & _
                                            "PWD=" + acess_pwd + ";" & _
                                            "UID=" + acess_usr + ";"
            aConexao.ConnectionTimeout = 30
            aConexao.CommandTimeout = 180
            aConexao.Open()
        End If


        aResultado.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        aResultado.Open(sqlquery, aConexao, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        OpenRecordset = aResultado
        aResultado = Nothing

    End Function
    Public Function abrir(ByVal sql As String)

        Dim aResultado As New ADODB.Recordset
        Dim tbconfig As ADODB.Recordset
        tbconfig = OpenRecordset("Select temporario from tbconfig")
        If tbconfig.RecordCount = 0 Then
            Return Nothing
            Exit Function
        End If
        acess_db = tbconfig.Fields("temporario").Value.ToString
        If File.Exists(acess_db) = False Then
            Return Nothing
            Exit Function
        End If

        If sql.ToUpper = "FECHAR" Then
            aconexao2.Close()
            Return False
            Exit Function
        End If

        If aconexao2.State = 0 Then
            aconexao2.ConnectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & acess_db
            aconexao2.Open()
        End If

        'aResultado2.Open(sql, aconexao2, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        aResultado.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        aResultado.Open(sql, aconexao2, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        abrir = aResultado
        aResultado = Nothing

    End Function
   
End Module
