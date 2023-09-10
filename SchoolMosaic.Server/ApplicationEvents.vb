Imports Microsoft.VisualBasic.ApplicationServices
Imports SchoolMosaic.Server.LocalizationManager

Namespace My
    ' Les événements suivants sont disponibles pour MyApplication :
    ' Startup : Déclenché au démarrage de l'application avant la création du formulaire de démarrage.
    ' Shutdown : Déclenché après la fermeture de tous les formulaires de l'application.  Cet événement n'est pas déclenché si l'application se termine de façon anormale.
    ' UnhandledException : Déclenché si l'application rencontre une exception non gérée.
    ' StartupNextInstance : Déclenché lors du lancement d'une application à instance unique et si cette application est déjà active. 
    ' NetworkAvailabilityChanged : Déclenché quand la connexion réseau est connectée ou déconnectée.

    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Dim Logger As New Logger
            Dim DB As New BaseManager
            Logger.Debug("Initializing language...")
            InitLanguage(Culture.TwoLetterISOLanguageName)
            Logger.Info("This app is running in " & Culture.TwoLetterISOLanguageName & " language")
            Logger.Debug("Language initialized")
        End Sub
    End Class
End Namespace
