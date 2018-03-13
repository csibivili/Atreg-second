function GoTo(section) {
    $('html, body').animate({ scrollTop: $(section).offset().top - 70 }, 1000);
}
