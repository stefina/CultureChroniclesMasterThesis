async.parallel({
	 music_result: function(callback){
	 	getMusicSuggestionsBySearchterm(searchterm, callback);
	 },
	movie_result: function(callback){
		getMovieSuggestionsBySearchterm(searchterm, callback);
	}
}