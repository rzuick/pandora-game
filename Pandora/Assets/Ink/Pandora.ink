Home, at the beginning of another dull day.
-> home

=== home ===
You woke up early this morning, like usual. However, there seems to be something in the air, something that spells...change. 

What will you do?

+ [Ignore things and go about your chores as usual.]
    The garden is a perfect place to begin your chores. You grab a jug of water and a bowl of berries and take them along with you. Better to eat on the run than not at all. 
    -> garden
+ [Walk around the village. Maybe someone knows something?]
    You head towards the village market, near the center of town.
    -> market
    
=== market ===
The market is quiet, not surprisingly. Your father insists that you be up early, but the rest of the people in this small village seem to enjoy their sleep.
+ [Head to the garden?]
    - You are bored, but there is one thing that always cheers you up: the garden! You head that way.
    -> garden
+ [Take a nap]
    - No one would notice if you dozed off for a little and then went home...right?
    -> news

=== garden ===
Gardening is the one chore you don't mind as much. Being the daughter of the village's chief means that there is always something more to do. 

The garden is the one place that you feel at peace, like there is no pressure. You begin working in the quiet morning air.

Hiss. Hiss.

What was that sound?

+ [Investigate the sound.]
    You look around the garden uncertainly. You haven't seen a snake in a very long time. Hopefully it was a loose cat instead.
    -> snake_encounter
+ [Ignore it. Nothing will ruin this quiet.]
    You bask in the sun, similar to the snake you saw earlier. But now it is time to see Baba. 
    -> news

=== snake_encounter ===
Oh my! That's rather long to be a garden snake. You approach it slowly, uncertainly. 

Snakes have been said to be omens of great fortune or terrible misfortune.

+ [It could be harmless. Try to feed it a berry.]
    You hold your palm out for the snake to eat from.
    -> snake_friend
+ [Get rid of it with the wooden hoe on the ground.]
    You grab the wicked looking hoe and stab at the snake. It hisses at you, almost offended, before slithering off into the woods behind your house. That was no ordinary snake. Baba should know.
    -> news
    
=== snake_friend === 
"Greetingssss to you, young human. Thank you for this ssssmall kindnesssss.
- I have been long wandering for ssssome ssssuch gesture."

Surprised as you are, you manage to dip your head in acknowledgement. Now is not the 
-time to be rude.

"Would you have water to spare? I am parched."
    [The snake slithers his tongue at you]

+ [Offer to grab the snake a cup from your home.] 
- "No rush my dear. I don't mind waiting."
    -> news

=== news ===
You hurry back to your house, but your father is there, blocking you from entering.

You note the excited and concerned look on his face. 

+ [Ask what is wrong.]
    "What is wrong, Baba?"
    -> journey_begins

+ [Ignore him. He can always tell you later.]
    - "Don't ignore me child. I have some news that marks coming change for this kingdom."
    You stand and wait for your father to continue. He obviously had a point to make.

-> journey_begins

=== journey_begins ===
"The king's herald just left, child. With him he brought quite the news. The king has decided that he is reaching an age of abdication. Since he has no heirs, the king has put out a call for all the beautiful young people in the land to journey to the capital. He says he will choose the most beautiful person as his successor!"

You are shocked at your father's news. Being queen would bring your family and village honor and prestige, but it would also be a grave responsibility. 

+ [Accept the invitation and leave?]
- "Baba, this is too great of an opportunity to pass up. With your blessing, I will go and visit the capital. Even if I am not chosen, I can still make great friends for our people."
    -> first_encounter
+ [Decline the invitation and stay.]

=== first_encounter ===
Your father packs a small bag of essentials for your journey to the capital. You leave, wishing him well in your absence. As you leave the village, you encounter a young boy, no more than 9 years old, sitting along the dirt road that leads in and out. 

You greet the boy and note the thirst that tightens his mouth and the way his shirt fits too loosely on his torso.

"Please, big sister, do you have any water to spare?"

+ [Give the boy a drink from the jug and an apple from your bag?]
    You hold out the jug of water so the boy can have his fill.
    "Here, child. Once you are done, go into the village and look for the chief. Tell him his Pandora has sent you and he will feed and clothe you."
    -> second_encounter
+ [Ignore the boy and keep walking.]
You continue on your way, determined to not be sidetracked again.

=== second_encounter ===
You continue walking the road away from your village. It weaves, winds, and merges into the forest, a canopy of trees beginning to block the view of the sun. You pause upon seeing an elderly woman sitting on a stone on the side of the road.
* ["Grandmother, are you well?"]
    "I am. I am thanking the sun for her generous warmth. Sit with me a moment."
        * * [You pause, considering how long it would take to get to the capital. Still, the king probably has many people vying for his attention, so one little stop won't hurt.] 
        "Very well, Grandmother. Please, have something to nourish your body as the sun nourishes your soul"
        The elderly woman smiles and accepts the sunflower seeds you offer.
        "Thank you child. As appreciation for your kindness, I will warn you. On the path ahead you will come across a grove of laughing trees. You must not laugh at them, for they will take offense and be of ill-temper."
        You nod in appreciation and thank the elderly woman, giving her an extra bag of seeds before continuing on your journey.
        -> third_encounter
        * * [You shake your head no]
        -> third_encounter
 * [You continue walking, turning your head to avoid her gaze.]
    "No time today, Grandmother"
    -> third_encounter



=== third_encounter ===
"Hahaha." You hear laughter in the distance, hysterical, and growing louder. Here, in a small copse of trees, you see a wondrous sight: The trees seem to have faces and, with them, they are laughing. How beautiful and terrifying. 

You suddenly remembered the warning Grandmother gave you and realize she was quite serious about these laughing trees. But, was her advice also sound?

+ [You decide to respect the trees and their privacy.]
    You lower your head to make yourself as inconspicuous as possible and skurry by. Who are you to disturb their joy.
+ [Grandmother couldn't be right about everything.]
    You refuse to be cowed by some odd trees. You laugh, loudly, and stare at the trees defiantly.
    - The trees' laughter turns to shrieking, their cries piercing the air. You run as fast as you can to escape them, hands covering your ears.
-> fourth_encounter

=== fourth_encounter ===
The laughter of the trees is still ringing in your ears, but thankfully you can see that the forest is thinning out. That means you must be quite close to the capital. 

You continue on, becoming more excited and more nervous at the thought that you might actually meet the king. What will he think of you?

Suddenly, your thoughts are interrupted by a jostle as you've walked into a man who is standing so still in the middle of the road. Before you can ask if he is alright, you notice that this is an odd man! His head is under his shoulder!

+ [Continue on, nonplussed]
    You acknowledge the man's difference and apologize. 
    "I am very sorry sir. I was not paying attention and seem to have walked into you. Do you need help?"
    "Indeed I do, young one. I was making my way to the capital. The king is looking for an heir you see!"
    ++ [You smile and offer him your arm]
        "I do know. I'm on my way there now. Come, let us greet the king together."
        -> royal_meeting
    ++ [You nod and wave goodbye before continuing on]
        "What an interesting man."
        -> fifth_encounter
+ [Yell at the man]
    "How rude! You cannot just stand in the middle of the road. You don't get special treatment just for being...different.Go on, out of the way!"
    You frown at the man and continue on the road towards the capital.
    ->fifth_encounter

=== fifth_encounter ===
You have made it to the capital! The capital is somehow smaller than you thought. That could be because of all of the buildings crammed around such a small space. 

You find a garden in the center, a place to take solace for a while. 
-> garden_two

=== garden_two ===
You sit and relish in the grounding presence of the garden. You hear a hiss and look around before noticing a snake that seems eerily familiar.

"Oh no! I forgot to bring my snake friend his water!" You look at this snake and frown. 
+ [Offer it water]
    The snake pokes it tongue out at you, as though in appreciation. You smile, reminded of your own little snake friend. 
    You realize the day is drawing to a close. Now would be a good time to try and see the king.
    -> royal_meeting
+ [Get up and head to the castle]
    You back away from the snake, cautiously. It wouldn't do to startle it and greet the king with a massive snake bite. But meet the king you shall!
    -> royal_meeting

=== royal_meeting ===
The castle courtyard is surprisingly empty. The king sent his message all throughout the kingdown so you expected to see many more people here. The air itself was hushed and almost still, as though something was lurking, waiting to expose itself.

You look around the courtyard and see, at the far end of it, what looks to be a figure in a dark cloak. You draw closer and reach a hand out in front of you.

+ ["Hello?"]
    The cloaked figure removes their hood and you gasp, awed by the royal presence in front of you. The king's eyes are kind, but firm, and you kneel humbly to be in his presence. He chuckles. 
    "There is no need to bow to me. You have demonstrated you are a beautiful soul and worthy to lead this kingdom. Rise, future queen."
    You remain kneeling, confused. 
    "But you don't know me, my king. How can you be sure I am worthy?"
    "I know your heart. Look at me, child." 
    You raise your eyes and watch, astonished, as the king shifts to take the form of the boy outside of your village who smiles impishly at you, before shifting to the old woman, his laugh sounding eerily similar to the laughing trees. He winks at you and you watch as his form shrinks to become the man with his head under his arm until finally, he shifts and becomes an extremely familiar sight. 
    You see the snake from your garden coiled in front of you, so regal and strong. 
    "You have shown yourself to be a caring and compassionate soul, beautiful because of your kindness and worthy because of your respect for the people of this kingdom and the land it is in. Now, rise queen, and prepare to greet your people"
    You stand shakily, and rise to your feet. Baba is certainly going to be surprised!
    -> the_end.end_1
+ ["Show yourself!]
    You grasp the cloak and yank it off of the mysterious figure and scream in horror. It is a grotesque creature, yet also oddly familiar. The more you stare at it, the more it reminds you of an amalgamation of who you encountered on your journey to the capital. 
    "Will you not bow down to your  king?" the creature growls and you fall to the floor in fear. It's as if you felt the reverberation of his voice down to your very bones.
    "I asked to be presented with the most beautiful and worthy young people in the land. Your actions today have shown me you are neither beautiful nor worthy."
    "Instead, you are cruel, judgmental, and unfit to lead anyone as there is still very much a jealous and spiteful child within your heart."
    "You, along with all others who have been found unworthy, shall be kept here in the capital until a worthy heir is found. They will decide what to do with the likes of you."
    You crumble to the floor, hopeless and dismayed. What will become of you now?
    -> the_end.end_2

=== the_end ===
= end_1
    And so it was that the kingdom rejoiced in the selection of their new queen. The people called her Pandora, an ode to her triumph over dark times and her role as the champion of the people's hope. 
    -> END
= end_2
    The king ultimately chose a young woman who, while not traditionally beautiful, was beautiful and worthy in her actions. She released all who had been held captive by the king and entrusted them with a solemn duty: to go out into the kingdom and teach the value of kindness, compassion, and good. 
    You became one of her most ardent supporters, determined to make your next voyage in the world one full of hope and wonder.

-> END