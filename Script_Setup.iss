; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Gestion Des Stagiaires"
#define MyAppVersion "1.0"
#define MyAppPublisher "ACG"
#define MyAppURL "http://www.example.com/"
#define MyAppExeName "gestion desstagiaires.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{1FEF3556-99E7-4801-B652-EBF3608B8CAC}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputDir=C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires
OutputBaseFilename=setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "french"; MessagesFile: "compiler:Languages\French.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\gestion desstagiaires.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\AxShockwaveFlashObjects.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\AxShockwaveFlashObjects.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\CircularProgressBar.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\CircularProgressBar.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\CrystalDecisions.CrystalReports.Engine.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\CrystalDecisions.ReportAppServer.ClientDoc.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\CrystalDecisions.ReportAppServer.CommLayer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\CrystalDecisions.ReportAppServer.CommonControls.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\CrystalDecisions.ReportAppServer.CommonObjectModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\CrystalDecisions.ReportAppServer.Controllers.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\CrystalDecisions.ReportAppServer.CubeDefModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\CrystalDecisions.ReportAppServer.DataDefModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\CrystalDecisions.ReportAppServer.DataSetConversion.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\CrystalDecisions.ReportAppServer.ObjectFactory.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\CrystalDecisions.ReportAppServer.Prompting.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\CrystalDecisions.ReportAppServer.ReportDefModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\CrystalDecisions.ReportAppServer.XmlSerialize.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\CrystalDecisions.ReportSource.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\CrystalDecisions.Shared.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\CrystalDecisions.Windows.Forms.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\FontAwesome.Sharp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\gestion desstagiaires.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\gestion desstagiaires.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\gestion desstagiaires.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\gestion_stagiaire2.accdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\gestion_stagiaire2.laccdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\ShockwaveFlashObjects.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\stdole.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\System.Data.OleDb.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\System.Data.OleDb.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\user\Desktop\gestion_des_stagiaires\gestion desstagiaires\gestion desstagiaires\bin\Debug\WinFormAnimation.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

