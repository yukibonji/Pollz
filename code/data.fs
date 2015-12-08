﻿module Pollz.Data
open System.IO
open FSharp.Data

// The folder with the data and file that keeps track of votes
let dataFolder = __SOURCE_DIRECTORY__ + "/../data"
let votesFile = dataFolder + "/votes.json"

// Use JSON type provider to get a type representing polls (used in `home.fs`)
type PollJson = JsonProvider<"code/sample-poll.json">

// ----------------------------------------------------------------------------
// STEP #2: Implement code to display the poll results. To do this, you first
// need to complete STEP #2 in `data.fs`. Then you'll need to implement the
// `getResults` function below using the `Data.loadPoll` helper and using
// `Data.votes` (which contains the votes)
// ----------------------------------------------------------------------------

/// A type alias that is used to get nicer type annotations for the 
/// functions below! The data structure to keep votes is a map where
/// we have poll names as the keys and list with all votes.
type Votes = Map<string, list<int>>

/// Load information about specified poll using PollJson.Load
let loadPoll name : PollJson.Root = 
  failwith "Not implemented!"

// Define a type `VotesJson` using the `code/sample-votes.json` as
// the sample file - we can then use this to read `votesFile`

/// Load information about votes from `votesFile` using 
/// `VotesJson`. You'll also need the `Map.ofSeq` function!
let loadVotes() : Votes =
  failwith "Not implemented!"

/// Define a global variable that keeps info of the votes 
/// (Call `loadVotes` once you implemented it!)
let votes : Votes = Map.empty 

// ----------------------------------------------------------------------------
// STEP #4: To implement updating of poll results, we'll make the `votes` 
// value mutable (it still keeps an immutable map, and we'll wrap it inside
// an F# agent later!). Then implement the `castVote` function below.
// ----------------------------------------------------------------------------

// We want to calculate a new `Votes` value from the old one. To do that,
// get the votes for a given `poll` (or empty list if it doesn't exist),
// append the new vote to the list and create a new `Votes` value (map) and
// then assign it to our global `votes` value.

let castVote (poll:string) (option:int) = 
  failwith "Not implemented!"


// ----------------------------------------------------------------------------
// STEP #5: After casting votes, we want to save the new data to `votesFile`
// so that it does not get lost during restart. To do that, implement the 
// `saveVotes` function which saves the `Votes` data structure into JSON
// using the types generated by the JSON type provider.
// Then call this function from `castVote` - to do this, you need to move
// it *above* `castVote`. The order matters in F#!
// ----------------------------------------------------------------------------


let ``TUTORIAL DEMO #5`` () = 
  // Once you define `VotesJson`, you can use the following to create
  // a list of JSON records storing votes for the individual polls
  (*
  let polls =
    [ VotesJson.Root("foo", Array.ofSeq [ 1; 0; 0; 1; 0 ]).JsonValue
      VotesJson.Root("bar", Array.ofSeq [ 1; 2; 2 ]).JsonValue ]
  *)

  // Given a list of JSON values, you can then create a JSON array:
  let json = 
    JsonValue.Array(Array.ofSeq [])

  // And get it as a formatted JSON, which you then need to save to `votesFile`
  json.ToString()


let saveVotes (votes:Votes) =
  failwith "Not implemented!"
