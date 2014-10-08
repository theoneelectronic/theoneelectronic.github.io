/*
    -------------
  > Styles import <
    -------------
 */
/*
   ------------
 > Brand styles <
   ------------
*/
/*
// Fonts -
@font-logo: "http://themes.googleusercontent.com/static/fonts/lato/v7/kcf5uOXucLcbFOydGU24WALUuEpTyoUstqEm5AMlJo4.woff";
@font-logo-bold: "http://fonts.gstatic.com/s/lato/v10/rZPI2gHXi8zxUjnybc2ZQALUuEpTyoUstqEm5AMlJo4.woff2";
@font-main: "http://themes.googleusercontent.com/static/fonts/notosans/v4/LeFlHvsZjXu2c3ZRgBq9nLO3LdcAZYWl9Si6vvxL-qU.woff";
@font-main-bold: "http://themes.googleusercontent.com/static/fonts/notosans/v4/PIbvSEyHEdL91QLOQRnZ16RDOzjiPcYnFooOUGCOsRk.woff";
@font-main-italic: "http://themes.googleusercontent.com/static/fonts/notosans/v4/ByLA_FLEa-16SpQuTcQn4LrIa-7acMAeDBVuclsi6Gc.woff";
@font-main-italicBold: "http://themes.googleusercontent.com/static/fonts/notosans/v4/9Z3uUWMRR7crzm1TjRicDhbnBKKEOwRKgsHDreGcocg.woff";

// Fonts Face
@font-face {
  font-family: 'Lato'; // Logo -
  font-style: normal;
  font-weight: 300;
  src: local('Lato Light'), local('Lato-Light'), url(@{font-logo}) format('woff');
}

@font-face {
  font-family: 'Lato'; // Logo -
  font-style: normal;
  font-weight: 700;
  src: local('Lato Bold'), local('Lato-Bold'), url(@{font-logo-bold}) format('woff');
}

@font-face {
  font-family: 'Noto';
  font-style: normal;
  font-weight: 400;
  src: local('Noto Sans'), local('NotoSans'), url(@{font-main}) format('woff');
}

@font-face {
  font-family: 'NotoB';
  font-style: normal;
  font-weight: 700;
  src: local('Noto Sans Bold'), local('NotoSans-Bold'), url(@{font-main-bold}) format('woff');
}

@font-face {
  font-family: 'NotoI';
  font-style: italic;
  font-weight: 400;
  src: local('Noto Sans Italic'), local('NotoSans-Italic'), url(@{font-main-italic}) format('woff');
}

@font-face {
  font-family: 'NotoIB';
  font-style: italic;
  font-weight: 700;
  src: local('Noto Sans Bold Italic'), local('NotoSans-BoldItalic'), url(@{font-main-italicBold}) format('woff');
}
*/
/*
   -------------
 > Header styles <
   -------------
*/
.navbar {
  background-color: #f1f1f1;
  padding: 2em 0;
}
@media (min-width: 1200px) {
  .navbar {
    /* background-image: url('../img/JRLogo.png');
    background-repeat: no-repeat;
    background-position: 70 15; */
    -webkit-transition: all 0.2s linear;
    -moz-transition: all 0.2s linear;
    -o-transition: all 0.2s linear;
    transition: all 0.2s linear;
  }
}
.navbar-small {
  padding: 0em;
  box-shadow: 0 1px 2px #e6e6e6;
}
.navbar-brand {
  color: #cf1010;
  font-size: 1.6em;
  font-family: 'Lato', sans-serif;
  /* background: url('../img/logo.png') no-repeat 0% 50%;
  padding-left:40px; */
}
.navbar-brand:hover {
  color: #a00c0c;
  /* background-image: url('../img/logo-hover.png'); */
}
.navbar-brand #first {
  font-weight: 700;
}
.navbar-brand #second {
  font-weight: 300;
}
.icon-menu li {
  margin: 5px;
}
.icon-menu li .plus-link {
  background: url('../img/plus-red.png') no-repeat;
  padding: 20px;
  transition: all 0.2s linear;
}
.icon-menu li .plus-link:hover {
  background: url('../img/plus-red-dark.png') no-repeat;
}
.icon-menu li .github-link {
  background: url('../img/hub-red.png') no-repeat;
  padding: 20px;
  transition: all 0.2s linear;
}
.icon-menu li .github-link:hover {
  background: url('../img/hub-red-dark.png') no-repeat;
}
.icon-menu li .instagram-link {
  background: url('../img/gram-red.png') no-repeat;
  padding: 20px;
  transition: all 0.2s linear;
}
.icon-menu li .instagram-link:hover {
  background: url('../img/gram-red-dark.png') no-repeat;
}
.icon-menu-small li {
  margin: 10px 5px;
}
.icon-menu-small li .plus-link {
  background: url('../img/plus-small.png') no-repeat;
  padding: 15px;
}
.icon-menu-small li .plus-link:hover {
  background: url('../img/plus-small-dark.png') no-repeat;
}
.icon-menu-small li .github-link {
  background: url('../img/hub-small.png') no-repeat;
  padding: 15px;
}
.icon-menu-small li .github-link:hover {
  background: url('../img/hub-small-dark.png') no-repeat;
}
.icon-menu-small li .instagram-link {
  background: url('../img/gram-small.png') no-repeat;
  padding: 15px;
}
.icon-menu-small li .instagram-link:hover {
  background: url('../img/gram-small-dark.png') no-repeat;
}
.navbar-toggle {
  background-color: #cf1010;
  border-radius: 0;
}
.navbar-toggle .icon-bar {
  background-color: #ffffff;
  border-radius: 0;
}
/*
   -----------
 > Main styles <
   -----------
*/
body {
  font-family: 'Noto Sans', sans-serif;
  font-size: 16px;
  color: #3f3f3f;
  background-color: #f1f1f1;
}
#main {
  padding-top: 107px;
}
.element {
  padding: 20px;
  text-align: center;
}
.element .text {
  text-align: left;
}
.element .col-md-pull-6 {
  text-align: right;
}
.element:not(:last-child)::after {
  content: "...";
  color: #f1f1f1;
  font-size: 3em;
}
.grey {
  background-color: #f1f1f1;
  margin-bottom: 0;
  text-align: center;
  padding: 100px 0;
}
.grey .message {
  width: 50%;
  margin: 0 auto;
}
.grey .message h1 {
  font-size: 7em;
  font-weight: 700;
}
.grey .message p {
  font-size: 1.8em;
}
.grey .message span {
  color: #cf1010;
  font-size: 2em;
}
.red {
  background-color: #cf1010;
  color: #ffffff;
  border-bottom: 1px solid #a00c0c;
}
.red h3 {
  font-weight: 700;
}
@media (min-width: 960px) {
  .red-left {
    border-right: 1px solid #a00c0c;
  }
}
.red-block {
  padding: 50px;
}
footer {
  background-color: #a00c0c;
  padding: 25px 50px;
  color: #ffffff;
}
.white {
  margin: 0 auto;
  width: 60%;
  color: #3f3f3f;
}
.white h2 {
  font-weight: 700;
}
.contact {
  width: 100%;
  padding: 10px;
  font-size: 1.1em;
  color: #a00c0c;
}
.send {
  position: relative;
  top: 3px;
  left: -10px;
}
/*
 *
 *
 */
