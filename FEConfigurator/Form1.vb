Imports System.Xml
Imports System.IO

Public Class Form1

    Dim ApplicationPath As String = My.Application.Info.DirectoryPath
    Dim DefXMLPath As String = ApplicationPath & "\def.xml"
    Dim ConfigXMLPath As String = ApplicationPath & "\config.xml"

    Dim tmpRegistryPath, tmpFilePath As String



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Check for Fable Explorer
        If My.Computer.FileSystem.FileExists(ApplicationPath & "\FableExplorer.exe") = False Then
            MsgBox("FableExplorer.exe is not found. Please, make sure you put FEConfigurator to the same directory as Fable Explorer!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Fable Explorer Configurator")
            btn_Save.Enabled = False
        End If

        ' Check for def.xml
        If My.Computer.FileSystem.FileExists(DefXMLPath) = False Then
            lbl_DefFileStatus.ForeColor = Color.Orange
            lbl_DefFileStatus.Text = "Missing!"
            Try
                My.Computer.FileSystem.WriteAllText(DefXMLPath, My.Resources.def, False)
                lbl_DefFileStatus.ForeColor = Color.Green
                lbl_DefFileStatus.Text = "Present."
            Catch ex As Exception
                MsgBox("Could not create def.xml file on path:" & vbCrLf & _
                       DefXMLPath & vbCrLf & _
                       "Make sure the location you launched this software is not read only, or the disk is not full!" & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, _
                       "Fable Explorer Configurator")
                btn_Save.Enabled = False
                lbl_DefFileStatus.ForeColor = Color.Red
                lbl_DefFileStatus.Text = "Missing! Could not create!"
            End Try
        Else
            lbl_DefFileStatus.ForeColor = Color.Green
            lbl_DefFileStatus.Text = "Present."
        End If

        ' Check for config.xml
        If My.Computer.FileSystem.FileExists(ConfigXMLPath) = False Then
            lbl_ConfigFileStatus.ForeColor = Color.Orange
            lbl_ConfigFileStatus.Text = "Missing!"
            ' config.xml does not exists. Creating a default one.
            WriteConfigFileToDisk(My.Resources.config)
        End If

        ' Now let's load the config file.
        Dim ConfigXMLDocument As New XmlDataDocument
        ConfigXMLDocument.Load(ConfigXMLPath)
        Dim xmlnode As XmlNodeList
        xmlnode = ConfigXMLDocument.GetElementsByTagName("ApplicationSettings")
        If xmlnode.Count = 0 Or xmlnode.Count > 1 Then
            Dim MsgAns As Integer = 0
            MsgAns = MsgBox("Your configuration file is likely corrupted." & vbCrLf & "Would you like if I create a new one for you?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, _
                   "Fable Explorer Configurator")
            If MsgAns = vbNo Then
                btn_Save.Enabled = False
                lbl_ConfigFileStatus.ForeColor = Color.Red
                lbl_ConfigFileStatus.Text = "Corrupted!"
                Return
            Else
                WriteConfigFileToDisk(My.Resources.def)
                MsgBox("Configuration file has been created. The application will restart now.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Fable Explorer Configurator")
                Application.Restart()
            End If
        End If

        ' Set up the controls accordingly on th e form
        Me.Enabled = False

        Try
            For Each node As XmlNode In xmlnode(0).ChildNodes
                Select Case node.Name
                    Case "UseRegistry"
                        If node.InnerText.Trim().ToUpper() = "TRUE" Then
                            rab_FromRegistry.Checked = True
                            rab_FromPath.Checked = False
                        ElseIf node.InnerText.Trim().ToUpper = "FALSE" Then
                            rab_FromRegistry.Checked = False
                            rab_FromPath.Checked = True
                        End If
                    Case "RegistryPath"
                        tmpRegistryPath = node.InnerText.Trim().Replace("\\", "\")
                        rab_FromRegistry_CheckedChanged(rab_FromRegistry, New System.EventArgs)
                    Case "InstallDirectory"
                        tmpFilePath = node.InnerText.Trim().Replace("\\", "\")
                        rab_FromPath_CheckedChanged(rab_FromPath, New System.EventArgs)
                    Case "InternalSplash"
                        If node.InnerText.Trim().ToUpper() = "TRUE" Then
                            cbx_CustomSplash.Checked = True
                        ElseIf node.InnerText.Trim().ToUpper = "FALSE" Then
                            cbx_CustomSplash.Checked = False
                        End If
                    Case "SplashFileName"
                        txb_SplashLocation.Text = node.InnerText.Trim()
                End Select
            Next
        Catch ex As Exception
            Dim MsgAns As Integer = 0
            MsgAns = MsgBox("Your configuration file is likely corrupted." & vbCrLf & "Would you mind if I create a new one for you?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, _
                   "Fable Explorer Configurator")
            If MsgAns = vbNo Then
                btn_Save.Enabled = False
                lbl_ConfigFileStatus.ForeColor = Color.Red
                lbl_ConfigFileStatus.Text = "Corrupted!"
                Return
            Else
                WriteConfigFileToDisk(My.Resources.config)
                MsgBox("Configuration file has been created. The application will restart now.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Fable Explorer Configurator")
                lbl_ConfigFileStatus.ForeColor = Color.Green
                lbl_ConfigFileStatus.Text = "Created. Need reload!"
                Application.Restart()
            End If
        End Try

        Me.Enabled = True
        lbl_ConfigFileStatus.ForeColor = Color.Green
        lbl_ConfigFileStatus.Text = "Present."

    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub WriteConfigFileToDisk(Optional ByVal FileContents As String = "")
        If FileContents <> "" Then
            Try
                My.Computer.FileSystem.WriteAllText(ConfigXMLPath, FileContents, False)
                lbl_ConfigFileStatus.ForeColor = Color.Green
                lbl_ConfigFileStatus.Text = "Present."
            Catch ex As Exception
                MsgBox("Could not create def.xml file on path:" & vbCrLf & _
                       DefXMLPath & vbCrLf & _
                       "Make sure the location you launched this software is not read only, or the disk is not full!" & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, _
                       "Fable Explorer Configurator")
                btn_Save.Enabled = False
                lbl_ConfigFileStatus.ForeColor = Color.Red
                lbl_ConfigFileStatus.Text = "Missing! Could not create!"
            End Try
        End If
    End Sub

    Private Sub txb_Location_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txb_Location.MouseClick
        Dim openfile As New OpenFileDialog()
        openfile.Filter = "Fable.exe|Fable.exe"
        openfile.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.ProgramFiles
        Dim dialogresult As Integer = openfile.ShowDialog()
        If dialogresult = Windows.Forms.DialogResult.Cancel Then
            tmpFilePath = ""
            Return
        ElseIf dialogresult = Windows.Forms.DialogResult.OK Then
            txb_Location.Text = My.Computer.FileSystem.GetFileInfo(openfile.FileName).DirectoryName
            tmpFilePath = txb_Location.Text
        End If
    End Sub

    Private Sub txb_SplashLocation_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txb_SplashLocation.MouseClick
        Dim openfile As New OpenFileDialog()
        openfile.Filter = "Safely supported image files (*.jpg, *.jpeg, *.bmp)|*jpg;*.jpeg;*.bmp"
        openfile.InitialDirectory = ApplicationPath
        Dim dialogresult As Integer = openfile.ShowDialog()
        If dialogresult = Windows.Forms.DialogResult.Cancel Then
            txb_SplashLocation.Text = ""
            Return
        ElseIf dialogresult = Windows.Forms.DialogResult.OK Then
            Dim selectedfilename = My.Computer.FileSystem.GetFileInfo(openfile.FileName).Name
            Try
                If My.Computer.FileSystem.GetFileInfo(openfile.FileName).DirectoryName = My.Computer.FileSystem.GetDirectoryInfo(ApplicationPath).FullName = False Then
                    My.Computer.FileSystem.CopyFile(openfile.FileName, ApplicationPath & "\" & selectedfilename)
                End If
            Catch ex As Exception
                MsgBox("Error during copying the selected image!" & vbCrLf & _
                       "Make sure the location you launched this software is not read only, or the disk is not full!" & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, _
                       "Fable Explorer Configurator")
                Return
            End Try
            txb_SplashLocation.Text = selectedfilename
        End If
    End Sub

    Private Sub rab_FromRegistry_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rab_FromRegistry.CheckedChanged
        If rab_FromRegistry.Checked = True Then
            txb_Location.Text = tmpRegistryPath
            txb_Location.Enabled = False
        End If
    End Sub

    Private Sub rab_FromPath_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rab_FromPath.CheckedChanged
        If rab_FromPath.Checked = True Then
            txb_Location.Text = tmpFilePath
            txb_Location.Enabled = True
        End If
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            Dim writer As New XmlTextWriter(ConfigXMLPath, System.Text.Encoding.UTF8)
            writer.WriteStartDocument(True)
            writer.Formatting = Formatting.Indented
            writer.Indentation = 4
            writer.WriteStartElement("FableExplorer")
            writer.WriteStartElement("ApplicationSettings")
            writer.WriteElementString("UseRegistry", IIf(rab_FromRegistry.Checked, "TRUE", "FALSE"))
            writer.WriteElementString("RegistryPath", tmpRegistryPath.Replace("\", "\\"))
            writer.WriteElementString("InstallDirectory", tmpFilePath.Replace("\", "\\"))
            writer.WriteElementString("InternalSplash", IIf(cbx_CustomSplash.Checked, "TRUE", "FALSE"))
            writer.WriteElementString("SplashFileName", txb_SplashLocation.Text)
            writer.WriteEndElement()
            writer.WriteEndElement()
            writer.WriteEndDocument()
            writer.Close()
        Catch ex As Exception
            MsgBox("Error during saving configuration file!" & vbCrLf & _
                   "Make sure the location you launched this software is not read only, or the disk is not full!" & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, _
                   "Fable Explorer Configurator")
            Return
        End Try

        MsgBox("Configuration successfully saved!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Fable Editor Configurator")

        Me.Close()


    End Sub

    Private Sub lnk_GitHub_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lnk_GitHub.MouseClick
        Dim webAddress As String = "https://github.com/eocorekuneho/FEConfigurator"
        Process.Start(webAddress)
    End Sub

#Region "Showing information text"
    Private Sub rab_FromRegistry_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rab_FromRegistry.MouseEnter
        rtb_InfoText.Text = My.Resources.infotext_from_registry
    End Sub
    Private Sub rab_FromRegistry_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rab_FromRegistry.MouseLeave
        rtb_InfoText.Text = ""
    End Sub

    Private Sub rab_FromPath_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rab_FromPath.MouseEnter
        rtb_InfoText.Text = My.Resources.infotext_from_filepath
    End Sub
    Private Sub rab_FromPath_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rab_FromPath.MouseLeave
        rtb_InfoText.Text = ""
    End Sub

    Private Sub txb_Location_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txb_Location.MouseEnter
        rtb_InfoText.Text = My.Resources.infotext_click_to_edit_path
    End Sub
    Private Sub txb_Location_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txb_Location.MouseLeave
        rtb_InfoText.Text = ""
    End Sub

    Private Sub cbx_CustomSplash_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_CustomSplash.MouseEnter
        rtb_InfoText.Text = My.Resources.infotext_use_custom_splash
    End Sub
    Private Sub cbx_CustomSplash_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_CustomSplash.MouseLeave
        rtb_InfoText.Text = ""
    End Sub

    Private Sub btn_Save_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.MouseEnter
        rtb_InfoText.Text = My.Resources.infotext_saveexit
    End Sub
    Private Sub btn_Save_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.MouseLeave
        rtb_InfoText.Text = ""
    End Sub

    Private Sub btn_Close_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.MouseEnter
        rtb_InfoText.Text = My.Resources.infotext_close
    End Sub
    Private Sub btn_Close_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.MouseLeave
        rtb_InfoText.Text = ""
    End Sub

    Private Sub lnk_GitHub_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnk_GitHub.MouseEnter
        rtb_InfoText.Text = My.Resources.infotext_github
    End Sub

    Private Sub lnk_GitHub_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnk_GitHub.MouseLeave
        rtb_InfoText.Text = ""
    End Sub
#End Region

End Class
