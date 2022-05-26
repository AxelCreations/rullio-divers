const { src, dest, watch } = require('gulp');

const sass = require('gulp-sass')(require('sass'));
const hb = require('gulp-hb');
const ts = require('gulp-typescript');

function css() {
  return src(['assets/scss/app.scss'])
    .pipe(sass({ outputStyle: 'compressed' }).on('error', sass.logError))
    .pipe(dest('../assets/css'));
}

function js() {
  return src('assets/ts/app.ts')
    .pipe(
      ts({
        noImplicitAny: true,
        lib: ['ES6', 'DOM'],
        target: 'es6',
        out: 'app.js',
      }).on('error', () => {})
    )
    .pipe(dest('../assets/js'));
}

function html() {
  return src('site/*.html')
    .pipe(hb().partials('template-parts/*.hbs'))
    .pipe(dest('../'));
}

exports.watch = () => {
  watch('assets/scss/*.scss', css);
  watch('assets/ts/*.ts', js);
  watch('site/*.html', html);
};
