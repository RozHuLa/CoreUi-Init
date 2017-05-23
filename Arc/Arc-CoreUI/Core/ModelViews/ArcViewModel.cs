using System;
using System.Collections.Generic;

namespace Arc_CoreUi.Core.ModelViews
{
    public abstract class ArcViewModel : IArcViewModel, IDisposable
    {
        public string PageTitle { get; set; }
        public string ShortcutIcon { get; set; }
        public IDictionary<string, string> Metas { get; set; }
        public IList<string> StyleSheets { get; set; }
        public IList<string> Javascripts { get; set; }

        public virtual void initialisation()
        {
            PageTitle = "CoreUI - Open Source Bootstrap Admin Template";
            Metas.Add("viewport", "width=device-width, initial-scale=1, shrink-to-fit=no");
            Metas.Add("description", "CoreUI - Open Source Bootstrap Admin Template");
            Metas.Add("author", "Łukasz Holeczek / Labaste Hugues");
            Metas.Add("keyword", "Bootstrap,Admin,Template,Open,Source,AngularJS,Angular,Angular2,Angular 2,Angular4,Angular 4,jQuery,CSS,HTML,RWD,Dashboard,React,React.js,Vue,Vue.js");
            StyleSheets.Add("/content/core-ui/css/font-awesome.min.css");
            StyleSheets.Add("/content/core-ui/css/simple-line-icons.css");
            StyleSheets.Add("/content/core-ui/css/style.css");

            Javascripts.Add("/scripts/core-ui/bower_components/jquery/dist/jquery.min.js");
            Javascripts.Add("/scripts/core-ui/bower_components/tether/dist/js/tether.min.js");
            Javascripts.Add("/scripts/core-ui/bower_components/bootstrap/dist/js/bootstrap.min.js");
            Javascripts.Add("/scripts/core-ui/bower_components/pace/pace.min.js");
            Javascripts.Add("/scripts/core-ui/bower_components/chart.js/dist/Chart.min.js");
            Javascripts.Add("/scripts/core-ui/js/app.js");
            Javascripts.Add("/scripts/core-ui/js/views/main.js");
            ShortcutIcon = "img/favicon.png";
        }

        public ArcViewModel()
        {
            Metas = new Dictionary<string, string>();
            StyleSheets = new List<string>();
            Javascripts = new List<string>();
            initialisation();
        }

        #region IDisposable Support
        private bool disposedValue = false; // Pour détecter les appels redondants

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: supprimer l'état managé (objets managés).
                }

                // TODO: libérer les ressources non managées (objets non managés) et remplacer un finaliseur ci-dessous.
                // TODO: définir les champs de grande taille avec la valeur Null.
                PageTitle = null;
                Metas = null;
                disposedValue = true;
            }
        }

        // TODO: remplacer un finaliseur seulement si la fonction Dispose(bool disposing) ci-dessus a du code pour libérer les ressources non managées.
        // ~ArcViewModel() {
        //   // Ne modifiez pas ce code. Placez le code de nettoyage dans Dispose(bool disposing) ci-dessus.
        //   Dispose(false);
        // }

        // Ce code est ajouté pour implémenter correctement le modèle supprimable.
        public void Dispose()
        {
            // Ne modifiez pas ce code. Placez le code de nettoyage dans Dispose(bool disposing) ci-dessus.
            Dispose(true);
            // TODO: supprimer les marques de commentaire pour la ligne suivante si le finaliseur est remplacé ci-dessus.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}