// body equals the html-sourcecode
$ = cheerio.load(body);
var imdbIdList = $('table.results tr td span.wlb_wrapper');