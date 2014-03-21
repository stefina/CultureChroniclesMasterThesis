async.parallel({
	music_result: function(callback){
		getMusicSuggestionsBySearchterm(searchterm, callback);
	},
	movie_result: function(callback){
		getMovieSuggestionsBySearchterm(searchterm, callback);
	}
},
function(err, results) { (*@\label{lst:asyncCallback}@*) 
	if(err){
		callback(err, searchterm);
	} else {
		var resultset = results.music_result.concat(results.movie_result);
		callback(null, resultset);
	}
});