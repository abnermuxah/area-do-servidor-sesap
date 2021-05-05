<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Menu.aspx.vb" Inherits="Formularios.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title>Menu Principal</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="apple-touch-icon" href="https://getbootstrap.com/docs/5.0/assets/img/favicons/apple-touch-icon.png" sizes="180x180">
<link rel="icon" href="https://getbootstrap.com/docs/5.0/assets/img/favicons/favicon-32x32.png" sizes="32x32" type="image/png">
<link rel="icon" href="https://getbootstrap.com/docs/5.0/assets/img/favicons/favicon-16x16.png" sizes="16x16" type="image/png">
<link rel="manifest" href="https://getbootstrap.com/docs/5.0/assets/img/favicons/manifest.json">
<link rel="mask-icon" href="https://getbootstrap.com/docs/5.0/assets/img/favicons/safari-pinned-tab.svg" color="#7952b3">
<link rel="icon" href="https://getbootstrap.com/docs/5.0/assets/img/favicons/favicon.ico">
<meta name="theme-color" content="#7952b3">
</head>
<script>
  window.ga=window.ga||function(){(ga.q=ga.q||[]).push(arguments)};ga.l=+new Date;
  ga('create', 'UA-146052-10', 'getbootstrap.com');
  ga('set', 'anonymizeIp', true);
  ga('send', 'pageview');
</script>
<body>
    
    <header class="navbar navbar-expand-md navbar-dark bd-navbar">
  <nav class="container-xxl flex-wrap flex-md-nowrap" aria-label="Main navigation">
    <a class="navbar-brand p-0 me-2" href="https://getbootstrap.com/" aria-label="Bootstrap">
      

    </button>

    <div class="collapse navbar-collapse" id="bdNavbar">
      <ul class="navbar-nav flex-row flex-wrap bd-navbar-nav pt-2 py-md-0">
        <li class="nav-item col-6 col-md-auto">
          <a class="nav-link p-2 active" aria-current="page" href="https://getbootstrap.com/" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;Navbar&#39;, &#39;Community links&#39;, &#39;Bootstrap&#39;);">Home</a>
        </li>
        <li class="nav-item col-6 col-md-auto">
          <a class="nav-link p-2" href="https://getbootstrap.com/docs/5.0/getting-started/introduction/" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;Navbar&#39;, &#39;Community links&#39;, &#39;Docs&#39;);">Docs</a>
        </li>
        <li class="nav-item col-6 col-md-auto">
          <a class="nav-link p-2" href="https://getbootstrap.com/docs/5.0/examples/" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;Navbar&#39;, &#39;Community links&#39;, &#39;Examples&#39;);">Examples</a>
        </li>
        <li class="nav-item col-6 col-md-auto">
          <a class="nav-link p-2" href="https://icons.getbootstrap.com/" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;Navbar&#39;, &#39;Community links&#39;, &#39;Icons&#39;);" target="_blank" rel="noopener">Icons</a>
        </li>
        <li class="nav-item col-6 col-md-auto">
          <a class="nav-link p-2" href="https://themes.getbootstrap.com/" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;Navbar&#39;, &#39;Community links&#39;, &#39;Themes&#39;);" target="_blank" rel="noopener">Themes</a>
        </li>
        <li class="nav-item col-6 col-md-auto">
          <a class="nav-link p-2" href="https://blog.getbootstrap.com/" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;Navbar&#39;, &#39;Community links&#39;, &#39;Blog&#39;);" target="_blank" rel="noopener">Blog</a>
        </li>
      </ul>

      <hr class="d-md-none text-white-50">

      <ul class="navbar-nav flex-row flex-wrap ms-md-auto">
       
        <li class="nav-item col-6 col-md-auto">
          <a class="nav-link p-2" href="https://twitter.com/getbootstrap" target="_blank" rel="noopener">
            <svg xmlns="http://www.w3.org/2000/svg" width="36" height="36" class="navbar-nav-svg d-inline-block align-text-top" viewBox="0 0 512 416.32" role="img"><title>Twitter</title><path fill="currentColor" d="M160.83 416.32c193.2 0 298.92-160.22 298.92-298.92 0-4.51 0-9-.2-13.52A214 214 0 0 0 512 49.38a212.93 212.93 0 0 1-60.44 16.6 105.7 105.7 0 0 0 46.3-58.19 209 209 0 0 1-66.79 25.37 105.09 105.09 0 0 0-181.73 71.91 116.12 116.12 0 0 0 2.66 24c-87.28-4.3-164.73-46.3-216.56-109.82A105.48 105.48 0 0 0 68 159.6a106.27 106.27 0 0 1-47.53-13.11v1.43a105.28 105.28 0 0 0 84.21 103.06 105.67 105.67 0 0 1-47.33 1.84 105.06 105.06 0 0 0 98.14 72.94A210.72 210.72 0 0 1 25 370.84a202.17 202.17 0 0 1-25-1.43 298.85 298.85 0 0 0 160.83 46.92"></path></svg>
            <small class="d-md-none ms-2">Twitter</small>
          </a>
        </li>
        <li class="nav-item col-6 col-md-auto">
          <a class="nav-link p-2" href="https://bootstrap-slack.herokuapp.com/" target="_blank" rel="noopener">
            <svg xmlns="http://www.w3.org/2000/svg" width="36" height="36" class="navbar-nav-svg d-inline-block align-text-top" viewBox="0 0 512 512" role="img"><title>Slack</title><path fill="currentColor" d="M210.787 234.832l68.31-22.883 22.1 65.977-68.309 22.882z"></path><path fill="currentColor" d="M490.54 185.6C437.7 9.59 361.6-31.34 185.6 21.46S-31.3 150.4 21.46 326.4 150.4 543.3 326.4 490.54 543.34 361.6 490.54 185.6zM401.7 299.8l-33.15 11.05 11.46 34.38c4.5 13.92-2.87 29.06-16.78 33.56-2.87.82-6.14 1.64-9 1.23a27.32 27.32 0 0 1-24.56-18l-11.46-34.38-68.36 22.92 11.46 34.38c4.5 13.92-2.87 29.06-16.78 33.56-2.87.82-6.14 1.64-9 1.23a27.32 27.32 0 0 1-24.56-18l-11.46-34.43-33.15 11.05c-2.87.82-6.14 1.64-9 1.23a27.32 27.32 0 0 1-24.56-18c-4.5-13.92 2.87-29.06 16.78-33.56l33.12-11.03-22.1-65.9-33.15 11.05c-2.87.82-6.14 1.64-9 1.23a27.32 27.32 0 0 1-24.56-18c-4.48-13.93 2.89-29.07 16.81-33.58l33.15-11.05-11.46-34.38c-4.5-13.92 2.87-29.06 16.78-33.56s29.06 2.87 33.56 16.78l11.46 34.38 68.36-22.92-11.46-34.38c-4.5-13.92 2.87-29.06 16.78-33.56s29.06 2.87 33.56 16.78l11.47 34.42 33.15-11.05c13.92-4.5 29.06 2.87 33.56 16.78s-2.87 29.06-16.78 33.56L329.7 194.6l22.1 65.9 33.15-11.05c13.92-4.5 29.06 2.87 33.56 16.78s-2.88 29.07-16.81 33.57z"></path></svg>
            <small class="d-md-none ms-2">Slack</small>
          </a>
        </li>
        <li class="nav-item col-6 col-md-auto">
          <a class="nav-link p-2" href="https://opencollective.com/bootstrap" target="_blank" rel="noopener">
            <svg xmlns="http://www.w3.org/2000/svg" width="36" height="36" fill="currentColor" fill-rule="evenodd" class="navbar-nav-svg d-inline-block align-text-top" viewBox="0 0 40 41" role="img"><title>Open Collective</title><path fill-opacity=".4" d="M32.8 21c0 2.4-.8 4.9-2 6.9l5.1 5.1c2.5-3.4 4.1-7.6 4.1-12 0-4.6-1.6-8.8-4-12.2L30.7 14c1.2 2 2 4.3 2 7z"></path><path d="M20 33.7a12.8 12.8 0 0 1 0-25.6c2.6 0 5 .7 7 2.1L32 5a20 20 0 1 0 .1 31.9l-5-5.2a13 13 0 0 1-7 2z"></path></svg>
            <small class="d-md-none ms-2">Open Collective</small>
          </a>
        </li>
      </ul>

     
    </div>
  </nav>
</header>
</body>
</html>
