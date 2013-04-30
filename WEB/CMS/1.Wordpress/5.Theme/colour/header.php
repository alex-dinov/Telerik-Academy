<!DOCTYPE HTML>
<html>

<head>
  <title><?php wp_title(); ?></title>
  <meta name="description" content="website description" />
  <meta name="keywords" content="website keywords, website keywords" />
  <meta http-equiv="content-type" content="text/html; charset=UTF-8" />
  <link rel="stylesheet" type="text/css" href="<?php bloginfo('stylesheet_url'); ?>" />
  <!-- modernizr enables HTML5 elements and feature detects -->
  <script type="text/javascript" src="<?php echo get_template_directory_uri(); ?>/js/modernizr-1.5.min.js"></script>
  <?php wp_head(); ?>
</head>

<body>
  <div id="container">
    <div id="main">
      <header>
        <div id="logo"><h1>CSS3_<a href="#">colour</a></h1></div>
        <?php wp_nav_menu(array(
        'theme_location' => 'lavaLampWithImage',
        'container' => 'nav',
        'menu_class' => 'lavaLampWithImage',
        'menu_id' => 'lava_menu')) ?>
        <!--<nav>
          <ul class="lavaLampWithImage" id="lava_menu">
            <li class="current"><a href="index.html">home</a></li>
            <li><a href="examples.html">examples</a></li>
            <li><a href="page.html">a page</a></li>
            <li><a href="another_page.html">another page</a></li>
            <li><a href="contact.php">contact</a></li>
          </ul>
        </nav>-->
      </header>
      <div id="site_content">
      	<?php get_sidebar('sidebar_container'); ?>
        <div id="content">