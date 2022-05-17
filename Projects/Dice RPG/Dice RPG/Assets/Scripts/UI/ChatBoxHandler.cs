using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatBoxHandler : MonoBehaviour
{
    public enum DialogTypes
	{
		SelectHover,
        Welcome,
        Win,
	}

	public List<string> WarriorSelectHoverDialog = new List<string>();
	public List<string> RoninSelectHoverDialog = new List<string>();
	public List<string> GunslingerSelectHoverDialog = new List<string>();
	public List<string> TechnomancerSelectHoverDialog = new List<string>();
	public List<string> WarlockSelectHoverDialog = new List<string>();
	public List<string> HealerSelectHoverDialog = new List<string>();

	public List<string> WarriorWelcomeDialog = new List<string>();
	public List<string> RoninWelcomeDialog = new List<string>();
	public List<string> GunslingerWelcomeDialog = new List<string>();
	public List<string> TechnomancerWelcomeDialog = new List<string>();
	public List<string> WarlockWelcomeDialog = new List<string>();
	public List<string> HealerWelcomeDialog = new List<string>();

	public List<string> WarriorWinDialog = new List<string>();
	public List<string> RoninWinDialog = new List<string>();
	public List<string> GunslingerWinDialog = new List<string>();
	public List<string> TechnomancerWinDialog = new List<string>();
	public List<string> WarlockWinDialog = new List<string>();
	public List<string> HealerWinDialog = new List<string>();

	public List<ChatBox> activeChatBoxes = new List<ChatBox>();
	public GameObject chatBoxPrefab;
    public static ChatBoxHandler Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

		PopulateLists();
    }

	public void PopulateLists()
	{   
		//Warrior SELECT HOVER
		WarriorSelectHoverDialog.Add("Pick me! This sword of mine is gonna make <wave>MINCED MEAT</wave> out of these creatures!");
		WarriorSelectHoverDialog.Add("Come on, you <wave>KNOW</wave> I'm the right choice here!");
		WarriorSelectHoverDialog.Add("Don't look more, I'm the strongest for sure!");
		WarriorSelectHoverDialog.Add("You see that sword? You see how big it is? It's a no brainer!");
		WarriorSelectHoverDialog.Add("I'm itching for <wiggle>ADVENTURE</wiggle>, for <wave>GREATNESS</wave>, for <shake>GLORRYYYYYYY</shake>!");
		WarriorSelectHoverDialog.Add("<wiggle>OBSERVE ME</wiggle>!... or whatever the line is.");
		//Ronin SELECT HOVER
		RoninSelectHoverDialog.Add("I would be honoured to be picked for this task.");
		RoninSelectHoverDialog.Add("I am ready, just say the word and I shall begin.");
		RoninSelectHoverDialog.Add("Choose me if you must, for I do not fear death.");
		RoninSelectHoverDialog.Add("I shall remain calm towards the face of danger, I promise you that.");
		RoninSelectHoverDialog.Add("I will stand proudly and fight alongside you, if you do wish for it.");
		RoninSelectHoverDialog.Add("I shall never turn down new challenges.");
		// Gunslinger SELECT HOVER
		GunslingerSelectHoverDialog.Add("Ooh they're looking at me! Look cool now. Should I strike a pose? I should strike a pose.");
		GunslingerSelectHoverDialog.Add("Think about it, I have guns. The guy next to me has a sword. Who do you think wins here?... No really, who does? Please say I do.");
		GunslingerSelectHoverDialog.Add("I can even do cool tricks with my gun!....... Wait hold on lemme try again.");
		GunslingerSelectHoverDialog.Add("Am I gonna get picked? Am I not? <wiggle>The suspense is killing me</wiggle>! Figuratively, of course.");
		GunslingerSelectHoverDialog.Add("I wonder if getting a horse would increase my chances of getting selected... I'd look so cool with a horse.");
		GunslingerSelectHoverDialog.Add("I heard every gun makes its own tune. Hope you get to listen to mine one day, it's pretty catchy!");
		// Technomancer SELECT HOVER
		TechnomancerSelectHoverDialog.Add("<shake>Nyehehe</shake>, and what do we have here? Ready to choose yet?");
		TechnomancerSelectHoverDialog.Add("I'm <wiggle>shockingly</wiggle> strong, despite the appearances! Get it?");
		TechnomancerSelectHoverDialog.Add("A little <shake>ZAPPITY ZAP</shake> here and there, wouldn't that be fun?");
		TechnomancerSelectHoverDialog.Add("Hehe<wiggle>HEHEHE</wiggle><shake>NYAHAHAH</shake>- no wait we got guests, not the time to go crazy just yet.");
		TechnomancerSelectHoverDialog.Add("All <wave>wired up</wave> and ready to go! Hehehe, good one. <wiggle>Oh, thank you</wiggle>!"); 
		TechnomancerSelectHoverDialog.Add("Don't mind the fried birds and rats around me... Just passing the time.");
		// Warlock SELECT HOVER
		WarlockSelectHoverDialog.Add("Please no...");
		WarlockSelectHoverDialog.Add("This looks like it'll take effort? Sorry, putting in effort goes against my culture...");
		WarlockSelectHoverDialog.Add("Maybe I should pretend I'm sleeping so they stop looking at me... Actually let's just go sleep.");
		WarlockSelectHoverDialog.Add("Don't you wanna go with the big sword guy or the lightning dude instead? I don't even have a weapon on me...");
		WarlockSelectHoverDialog.Add("<wiggle>Uugh</wiggle> I should have called in sick..");
		WarlockSelectHoverDialog.Add("Don't you <wiggle>dare</wiggle>.");
		// Healer SELECT HOVER
		HealerSelectHoverDialog.Add("I'm ready if you do choose me, but no hard feelings either way!");
		HealerSelectHoverDialog.Add("Whatever your decision may be, I will pray for you and your partner!");
		HealerSelectHoverDialog.Add("If I can express my feelings, I would love to be selected, but the choice remains yours my friend.");
		HealerSelectHoverDialog.Add("This must be a hard decision to make. You have all my support!");
		HealerSelectHoverDialog.Add("Evil awaits, and I have the power to let them pass peacefully and painlessly. This is the least we can do for these unfortunate souls!");
		HealerSelectHoverDialog.Add("Everyone here is formidable, despite some interesting personalities. You can't go wrong with anyone!");


		//Warrior WELCOME
		WarriorWelcomeDialog.Add("YES! Great choice! Let's go kick some <shake>BUTTS</shake>!");
		WarriorWelcomeDialog.Add("HAH! You've got taste my friend! <shake>LET'S DO THIS!</shake>");
		WarriorWelcomeDialog.Add("This. Is. Gonna. Be. <shake>EPIC</shake>!!! Ready to slay some monsters? I AM!");
		//Ronin WELCOME
		RoninWelcomeDialog.Add("I am honoured to have been chosen. I shall not disappoint you.");
		RoninWelcomeDialog.Add("You have my thanks. This blade of mine is yours to command.");
		RoninWelcomeDialog.Add("You have my gratitude for selecting me. I will carry out this mission until death itself comes banging at my door.");
		// Gunslinger WELCOME
		GunslingerWelcomeDialog.Add("Heya partner! Should I call you partner? I'm calling you partner.");
		GunslingerWelcomeDialog.Add("Perfect, these guns of mine were beginning to get <wave>thirsty for blood</wave>!... Ok that sounded better in my head.");
		GunslingerWelcomeDialog.Add("You've just partnered up with the fastest gunner in the west!... Wait are we in the west? Where even are we anyway?");
		// Technomancer WELCOME
		TechnomancerWelcomeDialog.Add("Oh, we got ourselves a fan of frying enemies' brains? We'll get along just great then!");
		TechnomancerWelcomeDialog.Add("You ready for the smell of fried zombie corpses? I never get tired of it!");
		TechnomancerWelcomeDialog.Add("Good timing, I was just getting bored of zapping nearby crows, I'm ready for bigger stuff!");
		// Warlock WELCOME
		WarlockWelcomeDialog.Add("<wiggle>Uuuugh</wiggle>, why did it have to be me?");
		WarlockWelcomeDialog.Add("Me? Of all people? I was just getting ready for my 4th mid-evening nap...");
		WarlockWelcomeDialog.Add("<wiggle>Uuuugh</wiggle> this is gonna take so much effort... I'm already tired just thinking about it.");
		// Healer WELCOME
		HealerWelcomeDialog.Add("Is this faith that brought us together? Well, let's get started!");
		HealerWelcomeDialog.Add("Thank you for believing in me. Together we shall cleanse this world from all evil!");
		HealerWelcomeDialog.Add("I am delighted to meet you! Now let's pray for our safety.");


		//Warrior WIN
		WarriorWinDialog.Add("Got any more like this?");
		WarriorWinDialog.Add("HAH, didn't even break a sweat!");
		WarriorWinDialog.Add("Come on, gimme an actual challenge!");
		WarriorWinDialog.Add("Is <wiggle>that</wiggle> the best they got??");
		WarriorWinDialog.Add("This is SO EASY, I could do it with my eyes closed!");
		WarriorWinDialog.Add("That last blow felt good just now!");
		WarriorWinDialog.Add("Is this EZ mode??");
		WarriorWinDialog.Add("<shake>NEXT!</shake>");
		WarriorWinDialog.Add("Is there anything that can stop us? I think NOT.");
		WarriorWinDialog.Add("That villain stood <shake>NO CHANCE!</shake>");
		WarriorWinDialog.Add("This fight will go down the history!");
		WarriorWinDialog.Add("This was <wave>EPIC!</wave>");
		WarriorWinDialog.Add("One step closer to glory!!");
		WarriorWinDialog.Add("Dibs on the next enemy!");
		WarriorWinDialog.Add("I can already hear the chants and tales of our accomplishments!");
		WarriorWinDialog.Add("Glad you chose me yet? Because I would be!");
		WarriorWinDialog.Add("FACE, MEET SWORD.");
		//Ronin WIN
		RoninWinDialog.Add("And so the win is ours.");
		RoninWinDialog.Add("We have won this battle, but we have yet to win the war.");
		RoninWinDialog.Add("I thank you for this fight.");
		RoninWinDialog.Add("Another soul falls to my blade.");
		RoninWinDialog.Add("No fear, no hesitation, no surprise, no doubt.");
		RoninWinDialog.Add("Sword and mind must be united, it is no surprise this was our victory.");
		RoninWinDialog.Add("I have made my ancestors proud.");
		RoninWinDialog.Add("We have fought today, so future generations won't have to.");
		RoninWinDialog.Add("I shall remember you, as I remember every enemy I fight.");
		RoninWinDialog.Add("The more we win, the more humbly we should walk.");
		RoninWinDialog.Add("I have learned a lot from this encounter, you have my thanks.");
		RoninWinDialog.Add("I took no pleasure in stealing your life away, but it had to be done.");
		RoninWinDialog.Add("I may not have an army of 47 ronins, but I vow to get the job done.");
		RoninWinDialog.Add("True strength does not prey on the weak.");
		RoninWinDialog.Add("When this ends, let's meet once more around a cup of sake.");
		RoninWinDialog.Add("There will be no rest until we have fulfilled our journey.");
		RoninWinDialog.Add("Your fighting spirit was commendable. Farewell.");
		// Gunslinger WIN
		GunslingerWinDialog.Add("Did you see that headshot just now? Tell me I did good!");
		GunslingerWinDialog.Add("Did you doubt me partner? Because I did, I really thought I was a goner.");
		GunslingerWinDialog.Add("Didn't even break a sweat! Okay maybe a little.");
		GunslingerWinDialog.Add("Another one bites the dust! I don't know what that means but it sounds cool.");
		GunslingerWinDialog.Add("Phew, I was so scared right there!... You weren't? Oh totally, me neither!");
		GunslingerWinDialog.Add("Am I ever gonna run out of bullets? Can't recall ever reloading that gun... Oh well.");
		GunslingerWinDialog.Add("They never saw it coming! Well, not the first shot at least.");
		GunslingerWinDialog.Add("God that was an ugly one!... Don't tell them I said that though.");
		GunslingerWinDialog.Add("Wait, I'm actually winning? I'm actually super strong aren't I!");
		GunslingerWinDialog.Add("Another win under our belt, partner! Got any booze to celebrate?");
		GunslingerWinDialog.Add("<shake>BANG</shake>, right between the eyes!... Did it even have eyes?");
		GunslingerWinDialog.Add("And that's how it's done! At least I think. I mean, it worked out, so.");
		GunslingerWinDialog.Add("<shake>PEW PEW PEW</shake>!... Oh, you didn't hear that.");
		GunslingerWinDialog.Add("Did I ever show you my revolver?..... Wait, you're saying it's not a revolver? What is it then?");
		GunslingerWinDialog.Add("Let's keep <wiggle>gunning</wiggle> for victory!");
		GunslingerWinDialog.Add("Should I start writing a diary of our victories? Okay, I'll buy the diary, you get to the writing!");
		GunslingerWinDialog.Add("Maybe the real victory is the friendship we built along the way!");
		// Technomancer WIN
		TechnomancerWinDialog.Add("<shake>Nyehehe</shake>, that was easier than expected.");
		TechnomancerWinDialog.Add("<shake>ZAP</shake> goes its head. That was a nice sound!");
		TechnomancerWinDialog.Add("Fried corpse's up for dinner tonight! Just kidding... <wiggle>unless.</wiggle>");
		TechnomancerWinDialog.Add("Hehe... <wiggle>Hehehe</wiggle>.... <shake>NYAHAHAHA</shake>- oops, almost lost my cool there.");
		TechnomancerWinDialog.Add("<wave>Aaahh yesss</wave>, this hits the spot.");
		TechnomancerWinDialog.Add("<shake>Nyehe</shake>, that one must have hurt.");
		TechnomancerWinDialog.Add("Ouch, I'm gonna <wave>charge</wave> you for that one!... Hehe, get it?");
		TechnomancerWinDialog.Add("You had so much potential... for a lab rat that is.");
		TechnomancerWinDialog.Add("Did sparks fly between us? Oh, that was probably my doing.");
		TechnomancerWinDialog.Add("Nothing you could have done, you were just <wiggle>sparking</wiggle> up the wrong tree! <shake>NYEHEHE</shake>");
		TechnomancerWinDialog.Add("What's the matter dead corpse, cat's <wiggle>watt</wiggle> your tongue?... Hmm, that one was a bit far-fetched wasn't it.");
		TechnomancerWinDialog.Add("Well, that was a <wiggle>volt</wiggle> from the blue.");
		TechnomancerWinDialog.Add("Can we keep the next one as a lab ra- </wiggle>I mean</wiggle> a pet? No? Okay, back to toasting them all then.");
		TechnomancerWinDialog.Add("Ah, medium rare, just how I like it!");
		TechnomancerWinDialog.Add("Smells like barbecue in here!");
		TechnomancerWinDialog.Add("<shake>Nyehe</shake>, your hair looks funny! Oh, that must be all the static.");
		TechnomancerWinDialog.Add("Wanna listen to some DC/AC on the way to the next bad guy?"); // TO CHECK IF I CAN DO THIS
		// Warlock WIN
		WarlockWinDialog.Add("That was tiring... Is it nap time yet?");
		WarlockWinDialog.Add("Please let's just go back home and sleep. I even have an extra bed for you.");
		WarlockWinDialog.Add("Ugh, how many more before this is over?");
		WarlockWinDialog.Add("<wiggle>Yaaaaaawn</wiggle>... Oh, we're still doing this?");
		WarlockWinDialog.Add("<wiggle>Uuuuuuuuuuuuuuugh</wiggle>.. Sorry, that was just me being bored from all this.");
		WarlockWinDialog.Add("There has to be a law against making me do all that work.");
		WarlockWinDialog.Add("<wiggle>Wait, hold on, pause, I gotta catch my breath</wiggle>... for a day or two, maybe a week?");
		WarlockWinDialog.Add("Why are we even doing this? They don't seem that bad to me.");
		WarlockWinDialog.Add("That spot right there would be great for a nap- <wiggle>aaaand</wiggle> we just walked past it, okay, cool.");
		WarlockWinDialog.Add(".................. ................ ............... Oh, you were expecting a comment? Demanding, are we?");
		WarlockWinDialog.Add("Is this <wiggle>ever</wiggle> gonna end? It's not like we're stuck in some sort of endless idle game.");
		WarlockWinDialog.Add("I miss my bed..... No, you don't get it, it's a <wave>really</wave> good bed.");
		WarlockWinDialog.Add("Hang on, was that my cousin? Oh sorry, they looked similar.");
		WarlockWinDialog.Add("Can we slow down a bit? I think I pulled a finger muscle.");
		WarlockWinDialog.Add("Why are all the bad guys monsters? Where are the bad humans for a change?");
		WarlockWinDialog.Add("Could these souls fly a bit higher? They keep hitting my horns.");
		WarlockWinDialog.Add("My life aspiration is to do nothing. You're not helping with that.");
		// Healer WIN
		HealerWinDialog.Add("May your soul rest in peace, and your sins be forgiven.");
		HealerWinDialog.Add("We are doing good here, let's keep going!");
		HealerWinDialog.Add("Another soul has left this plane by our hands. Let's repent later.");
		HealerWinDialog.Add("Well done! We're a great team aren't we?");
		HealerWinDialog.Add("That poor soul.. I'm so sorry, but it had to be done.");
		HealerWinDialog.Add("I will pray for you tonight.");
		HealerWinDialog.Add("Sending them off in the most painless way possible, that's the right way to do it!");
		HealerWinDialog.Add("you're getting better and better! I'm glad to be partnered up with you.");
		HealerWinDialog.Add("This is a huge task, but I'm relieved I get to do it with such a competent individual like you!");
		HealerWinDialog.Add("All that training is really paying off!");
		HealerWinDialog.Add("I do feel a bit sad about these monsters... They didn't choose to be born this way.");
		HealerWinDialog.Add("Let's send them off with a prayer shall we? I trust you know your prayers well of course?");
		HealerWinDialog.Add("Let me know if you're getting tired, I've got just the thing to freshen you up!");
		HealerWinDialog.Add("Do you think this contradicts my hippocratic oath? Nah, surely not!");
		HealerWinDialog.Add("Life and death are two sides of the same coin.");
		HealerWinDialog.Add("Your mortal journey may end here, but fear not; much awaits for you in the afterlife.");
		HealerWinDialog.Add("Fun fact: I very much dislike apples! Not sure why.");

		// lose ideas:
		// Technomancer: Hang on, I've got some spare batteries.
		// Technomancer: Oh good, you remembered how to jump start my heart back!
		// Technomancer: This time I'll up the voltage.
		// Ronin: Just as a blade is forged through a thousand hits, each defeat makes me stronger.
		// Warlock: Oh we're just going right back to it are we? Not even a cup of coffee first?
		// Warlock: Oh joy, another rise and shine.
		// Healer: Looks like the fates have more in store for us!
	}

	public void Speak(DialogTypes type)
	{
		CheckToClearChatBoxes();

		GameObject chatBox = null;
		if (Player.Instance.character != null)
			chatBox = Instantiate(chatBoxPrefab, Camera.main.WorldToScreenPoint(Player.Instance.character.chatBoxPosition.position), Quaternion.identity, Battle.Instance.uiCanvas.transform);
		else
			chatBox = Instantiate(chatBoxPrefab, Camera.main.WorldToScreenPoint(ClassesObjects.Instance.characters[(CurrentClass.classes)EllipsePositions.Instance.currentSelected].chatBoxPosition.position), Quaternion.identity, Battle.Instance.uiCanvas.transform);

		string dialog = string.Empty;

		switch (type)
		{
			case DialogTypes.SelectHover:
				dialog = GetSelectHoverDialog();
				break;
			case DialogTypes.Welcome:
				dialog = GetWelcomeDialog();
				break;
			case DialogTypes.Win:
				dialog = GetWinDialog();
				break;
		}

		ChatBox curChatBox = chatBox.GetComponent<ChatBox>();
		curChatBox.UpdateText(dialog);

		activeChatBoxes.Add(curChatBox);
    }

	public void CheckToClearChatBoxes()
	{
		if (activeChatBoxes.Count > 0)
		{
			activeChatBoxes[0].QuickDestroyChatBox();
		}
	}

	public string GetSelectHoverDialog()
	{
		string chosenDialog = string.Empty;

		switch ((CurrentClass.classes)EllipsePositions.Instance.currentSelected)
		{
			case CurrentClass.classes.Warrior:
				chosenDialog = WarriorSelectHoverDialog[Random.Range(0, WarriorSelectHoverDialog.Count)];
				break;
			case CurrentClass.classes.Ronin:
				chosenDialog = RoninSelectHoverDialog[Random.Range(0, RoninSelectHoverDialog.Count)];
				break;
			case CurrentClass.classes.Gunslinger:
				chosenDialog = GunslingerSelectHoverDialog[Random.Range(0, GunslingerSelectHoverDialog.Count)];
				break;
			case CurrentClass.classes.Technomancer:
				chosenDialog = TechnomancerSelectHoverDialog[Random.Range(0, TechnomancerSelectHoverDialog.Count)];
				break;
			case CurrentClass.classes.Warlock:
				chosenDialog = WarlockSelectHoverDialog[Random.Range(0, WarlockSelectHoverDialog.Count)];
				break;
			case CurrentClass.classes.Healer:
				chosenDialog = HealerSelectHoverDialog[Random.Range(0, HealerSelectHoverDialog.Count)];
				break;
		}

		return chosenDialog;
	}

	public string GetWelcomeDialog()
	{
		string chosenDialog = string.Empty;

		switch (Player.Instance.currentClass)
		{
			case CurrentClass.classes.Warrior:
				chosenDialog = WarriorWelcomeDialog[Random.Range(0, WarriorWelcomeDialog.Count)];
				break;
			case CurrentClass.classes.Ronin:
				chosenDialog = RoninWelcomeDialog[Random.Range(0, RoninWelcomeDialog.Count)];
				break;
			case CurrentClass.classes.Gunslinger:
				chosenDialog = GunslingerWelcomeDialog[Random.Range(0, GunslingerWelcomeDialog.Count)];
				break;
			case CurrentClass.classes.Technomancer:
				chosenDialog = TechnomancerWelcomeDialog[Random.Range(0, TechnomancerWelcomeDialog.Count)];
				break;
			case CurrentClass.classes.Warlock:
				chosenDialog = WarlockWelcomeDialog[Random.Range(0, WarlockWelcomeDialog.Count)];
				break;
			case CurrentClass.classes.Healer:
				chosenDialog = HealerWelcomeDialog[Random.Range(0, HealerWelcomeDialog.Count)];
				break;
		}

		return chosenDialog;
	}

	public string GetWinDialog()
	{
		string chosenDialog = string.Empty;

		switch (Player.Instance.currentClass)
		{
			case CurrentClass.classes.Warrior:
				chosenDialog = WarriorWinDialog[Random.Range(0, WarriorWinDialog.Count)];
				break;
			case CurrentClass.classes.Ronin:
				chosenDialog = RoninWinDialog[Random.Range(0, RoninWinDialog.Count)];
				break;
			case CurrentClass.classes.Gunslinger:
				chosenDialog = GunslingerWinDialog[Random.Range(0, GunslingerWinDialog.Count)];
				break;
			case CurrentClass.classes.Technomancer:
				chosenDialog = TechnomancerWinDialog[Random.Range(0, TechnomancerWinDialog.Count)];
				break;
			case CurrentClass.classes.Warlock:
				chosenDialog = WarlockWinDialog[Random.Range(0, WarlockWinDialog.Count)];
				break;
			case CurrentClass.classes.Healer:
				chosenDialog = HealerWinDialog[Random.Range(0, HealerWinDialog.Count)];
				break;
		}

		return chosenDialog;
	}
}
