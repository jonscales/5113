
%% Jon Scales
%% APL  CMPS 5113
%% Fall 2024

%% Program 2
%% Prolog using SWISH IDE
%% Program to generate ratings for restaurants based on facts and rules

%% restaurant facts
%% predicate(restaurant name, food ethnicity, cost, food quality, restaurant cleanliness)
%% E=ethnicity = american, aisian, italian, mexican
%% cost represented as $: $$$= >=$30, $$= >=$15 $= <$15 
%% quality and cleanliness ranked low, med, high

restaurant(chilis, american, $$, med, high).
restaurant(applebees, american, $$, med, med).
restaurant(parkway_grill, american, $, high, med).
restaurant(pelicans, american, $$$, high, high).
restaurant(texas_roadhouse, american, $$$, high, med).
restaurant(cotton_patch, american, $$, med, high).
restaurant(cheddars, american, $$, med, high).
restaurant(fox_hill, american, $$$, high, high).
restaurant(branding_iron_bbq, american, $$, high, med).
restaurant(dickeys_bbq, american, $$, med, med).
restaurant(olvie_garden, italian, $$, med, high).
restaurant(napolis, italian, $, high, med).
restaurant(johnny_carinos, italian, $$, med, med).
restaurant(mias_bistro, italian, $$, med, med).
restaurant(genovas, italian, $$, low, low).
restaurant(samurai_of_tokyo, asian, $$, med, med).
restaurant(thai_orchid, asian, $, med, med).
restaurant(sakura, asian, $$, high, high).
restaurant(hoshi_japanese_steakhouse, asian, $$$, high, high).
restaurant(volcano_japanese_fusion, asian, $$, med, med).
restaurant(pho_viet, asian, $$, low, med).
restaurant(taki_ramen, asian, $$, med, med).
restaurant("t&k_kitchen", asian, $, med, med).
restaurant(hunan_buffet, asian, $$, med, med).
restaurant(grand_buffet, asian, $$, med, med).
restaurant(el_norteno_1, mexican, $, med, med).
restaurant(el_norteno_2, mexican, $, med, med).
restaurant(don_joses, mexican, $$, med, high).
restaurant(el_rodeo, mexican, $$, high, med).
restaurant(el_tapatio, mexican, $$, med, med).
restaurant(taco_casa, mexican, $, med, med).
restaurant(jefes, mexican, $$, med, med).
restaurant(joeys, mexican, $, high, med).
restaurant(casa_manana, mexican, $$, med, low).

%%rating rules
%%N=name, E=ethnicity, $$$= >=$30, $$= >=$15 $= <$15 
%% rating rubric:  
%% 5  any $, quality & clean - high
%% 4 cost $$ or $, quality OR clean can be med, other must be high
%% 3 cost $$$ with one med attribute, OR cost $ with 2 med attributes
%% 2 cost $$$ or $$ with 2 med attributes
%% 1 any cost with >=1 low attribute


%%ratings irrespective of food type
%%3
rating(N, 5):-
    restaurant(N, _, $$$, high, high);
    restaurant(N, _, $$, high, high);
    restaurant(N, _, $, high, high).
%%4
rating(N, 4):-
    restaurant(N, _, $$, med, high);
    restaurant(N, _, $$, high, med);
	restaurant(N, _, $, high, med);
    restaurant(N, _, $, med, high).
%%3
rating(N, 3):-
    restaurant(N, _, $$$, med, high);
    restaurant(N, _, $$$, high, med);
    restaurant(N, _, $, med, med).
%%2
rating(N, 2):-
    restaurant(N, _, $$$, med, med);
    restaurant(N, _, $$, med, med).
%%15
rating(N, 1):-   
	restaurant(N, _, $$$, low, high);
	restaurant(N, _, $$$, low, med);   
	restaurant(N, _, $$$, high, low);
	restaurant(N, _, $$$, med, low);
	restaurant(N, _, $$$, low, low);
	restaurant(N, _, $$, low, high);
	restaurant(N, _, $$, low, med);
	restaurant(N, _, $$, high, low);
	restaurant(N, _, $$, med, low);
	restaurant(N, _, $$, low, low);    
	restaurant(N, _, $, low, high);
	restaurant(N, _, $, low, med);
	restaurant(N, _, $, high, low);
	restaurant(N, _, $, med, low);
	restaurant(N, _, $, low, low).

%%ratings including food ethnicity
rating(N, E, 5):-restaurant(N, E, $$$, high, high).
rating(N, E, 5):-restaurant(N, E, $$, high, high).
rating(N, E, 5):-restaurant(N, E, $, high, high).

rating(N, E, 4):-restaurant(N, E, $$, med, high).
rating(N, E, 4):-restaurant(N, E, $$, high, med).
rating(N, E, 4):-restaurant(N, E, $, med, high).
rating(N, E, 4):-restaurant(N, E, $, high, med).

rating(N, E, 3):-restaurant(N, E, $$$, med, high).
rating(N, E, 3):-restaurant(N, E, $$$, high, med).
rating(N, E, 3):-restaurant(N, E, $$, med, med).

rating(N, E, 2):-restaurant(N, E, $$$, med, med).
rating(N, E, 2):-restaurant(N, E, $, med, med).

rating(N, E, 1):-restaurant(N, E, $$$, low, high).
rating(N, E, 1):-restaurant(N, E, $$$, low, med).    
rating(N, E, 1):-restaurant(N, E, $$$, high, low).
rating(N, E, 1):-restaurant(N, E, $$$, med, low).
rating(N, E, 1):-restaurant(N, E, $$$, low, low).
rating(N, E, 1):-restaurant(N, E, $$, low, high).
rating(N, E, 1):-restaurant(N, E, $$, low, med).
rating(N, E, 1):-restaurant(N, E, $$, high, low).
rating(N, E, 1):-restaurant(N, E, $$, med, low).
rating(N, E, 1):-restaurant(N, E, $$, low, low).    
rating(N, E, 1):-restaurant(N, E, $, low, high).
rating(N, E, 1):-restaurant(N, E, $, low, med).
rating(N, E, 1):-restaurant(N, E, $, high, low).
rating(N, E, 1):-restaurant(N, E, $, med, low).
rating(N, E, 1):-restaurant(N, E, $, low, low).

%%recommendation rules
%%rules to query food type and return restuarants rated by category 
%%overall recommended with rating >=4
recommendation(N, E):-rating(N, E, 4);rating(N, E, 5).
posh(N, E):-rating(N, E, 4);rating(N, E, 5).

%% recommend medium ratings
mediocre(N, E):-rating(N, E, 3); rating(N, E, 2).

%%which places are dives??
dives(N, E):-rating(N, E, 1).
                       
%%recommendations based on cost regardless of rating stats
%%expensive = $$$ (>=$30), cheap = <$30
expensive(N, E):-restaurant(N, E, $$$, _, _).
cheap(N, E):-restaurant(N, E, $$, _, _);restaurant(N, E, $, _, _).

%%recommendation based on rating >=4 AND cost <$30
goodcheap(N, E):-
    restaurant(N, E, $, _, _);restaurant(N, E, $$, _, _),
    rating(N, E, 4);rating(N, E, 5).

%% recommendation based on cost
cost(N, $):-restaurant(N, _, $, _, _).
cost(N, $$):-restaurant(N, _, $$, _, _).
cost(N, $$$):-restaurant(N, _, $$$, _, _).

%% recommendation based on cost & food type
cost(N,E, $):-restaurant(N, E, $, _, _).
cost(N, E, $$):-restaurant(N, E, $$, _, _).
cost(N, E, $$$):-restaurant(N, E, $$$, _, _).

%%query rules as above for restaurants irrespective of food ethnicity 
recommendation(N):-rating(N, 4);rating(N, 5).    
posh(N):-rating(N, 4);rating(N, 5).
mediocre(N):-rating(N, 3); rating(N, 2).
dives(N):-rating(N, 1).
expensive(N):-restaurant(N, _, $$$, _, _).
cheap(N):-restaurant(N, _, $$, _, _);restaurant(N, _, $, _, _).
goodcheap(N):-
    restaurant(N, _, $, _, _);restaurant(N, _, $$, _, _),
    rating(N, 4);rating(N, 5).

