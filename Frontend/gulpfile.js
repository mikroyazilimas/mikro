//
// --------------------
// Gulp File
// --------------------
//

const gulp 			= require('gulp')
const gutil 		= require('gulp-util')
const notify 		= require('gulp-notify')
const less 			= require('gulp-less')
const babel         = require('gulp-babel')
const autoprefix 	= require('gulp-autoprefixer')
const cssmin 		= require('gulp-cssmin')
const uglify        = require('gulp-uglify')
const imagemin      = require('gulp-imagemin')
const svgmin        = require('gulp-svgmin')
const concat 		= require('gulp-concat')
const browserSync 	= require('browser-sync').create()

const projectName   = 'mikro-yazilim'

const imageSource   = 'source/images'
const cssDist       = 'dist/css'
const jsDist        = 'dist/javascript'
const imageDist     = 'dist/images'
const lessSource    = 'source/less'

const jsSource = [
	'source/javascripts/jquery-3.3.1.min.js',
    'source/javascripts/jquery.animateNumber.min.js',
    'source/javascripts/owl.js',
    'source/javascripts/fontawesome.js',
    'source/javascripts/select2.js',
	'source/javascripts/general.js'
];

// Compile Less, autoprefix CSS3, and save to target CSS directory
gulp.task('less', () => {
    return gulp.src(lessSource + '/app.less')
        .pipe(less().on('error', gutil.log))
        .pipe(autoprefix())
		.pipe(cssmin())
        .pipe(gulp.dest(cssDist))
})

// Compile Javascript vs Babel and save to targe Javascript directory
gulp.task('javascript', () => {
    gulp.src(jsSource)
        .pipe(concat(projectName + '.js'))
        .pipe(gulp.dest(jsDist))
})

// Image Minify
gulp.task('imagemin', () => {
    gulp.src(imageSource + '/**/*')
        .pipe(imagemin())
        .pipe(gulp.dest(imageDist))
})

// Svg Minify
gulp.task('svgmin', function () {
    return gulp.src(imageSource + '/**/*.svg')
        .pipe(svgmin())
        .pipe(gulp.dest(imageDist))
})

// Watch
gulp.task('watch', () => {
    gulp.watch(lessSource + '/**/*.less', ['less'])
    gulp.watch(jsSource, ['javascript'])
    gulp.watch(imageSource + '/**/*.png', ['imagemin'])
    gulp.watch(imageSource + '/**/*.svg', ['svgmin'])
})

// What tasks does running gulp trigger?
gulp.task('default', ['less', 'javascript', 'imagemin', 'svgmin', 'watch'])
