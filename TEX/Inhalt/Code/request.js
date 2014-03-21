// searchterm equals the year of the searchQuery

request('http://www.imdb.com/search/title?release_date=' + searchterm + ',' + searchterm + '&title_type=feature', function(err, resp, body){
	// body contains the source-code of the given URL
});