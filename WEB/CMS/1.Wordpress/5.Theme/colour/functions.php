<?php

$sidebar_args = array(
	'id' => 'sidebar_container',
	'name' => 'Main Sidebar',
	'before_widget' => '<div class="sidebar">',
	'after_widget' => '</div>',
	);

register_sidebar($sidebar_args);

register_nav_menu('lavaLampWithImage', 'My menu');

function correct_frontend_scripts() {
    wp_enqueue_script( 
    	'my-script-handle', 
		get_template_directory_uri().'/js/jquery.easing.min.js',
		array( 'jquery' ) );            
}    

add_action( 'wp_enqueue_scripts', 'correct_frontend_scripts' );