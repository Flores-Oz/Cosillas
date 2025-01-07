#Anotaciones
####Program
Contiene  la configuración del entorno de desarrollo del archivo launchSettings.json.

####wwwRot
La carpeta wwwroot contiene recursos estáticos, como archivos de imagen, JavaScript (.js) y hojas de estilo (.css).

####Components, Components/Pages y Components/Layout
Un componente es una parte independiente de la interfaz de usuario (UI) con lógica de procesamiento opcional. Los componentes se pueden anidar, reutilizar y compartir entre proyectos.

Los componentes anidados dentro de otros componentes y que no son accesibles directamente ("enrutable") en una dirección URL se colocan en la carpeta Components. Los componentes que son enrutables a través de una dirección URL suelen colocarse en la carpeta Components/Pages.

Components/Layout contiene lo siguiente:
    Componente MainLayout (MainLayout.razor): el componente de diseño principal de la aplicación.
    MainLayout.razor.css: hoja de estilos del diseño principal de la aplicación.
    Componente NavMenu (NavMenu.razor): implementa la navegación de barra lateral. Este componente usa varios componentes NavLink para representar vínculos de navegación a otros componentes Razor.
    NavMenu.razor.css: hoja de estilos del menú de navegación de la aplicación.

####Components/_Imports.razor
El archivo _Imports (_Imports.razor) incluye Razor directivas comunes que incluir en los componentes Razor de la aplicación. Las directivas Razor son palabras clave reservadas con el prefijo @

####Components/App.razor

El componente App (App.razor) es el componente raíz de la aplicación que incluye:

Marcado HTML.
El componente Routes.
El script Blazor (etiqueta <script> para blazor.web.js).
El componente raíz es el primer componente que carga la aplicación.

####Components/Routes.razor
El componente Routes (Routes.razor) configura el enrutamiento de la aplicación.

####appsettings.json
El archivo appsettings.json contiene datos de configuración, como las cadenas de conexión.

#####Comandos
dotnet aspnet-codegenerator blazor CRUD -dbProvider SQL -dc WebAppMovies.Data.WebAppMoviesContext -m Movie -outDir Components/Pages
