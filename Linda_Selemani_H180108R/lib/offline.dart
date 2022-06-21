import 'package:flutter/material.dart';

class Offline extends StatefulWidget {
  static String id = 'Offline';
  @override
  _Offline createState() => _Offline();
}

@override
Widget build(BuildContext context) {
  return Container(
  );
}

class _Offline extends State<Offline> {
  // Title List Here
  var titleList = [
    "Asthma",
    "Broken Arm",
    "Broken Leg",
    "Burns",
    "Chest Pain",
    "Choking For Adults",
    "Choking For Babies",
    "Contaminated Eyes",
    "CPR",
    "Drowning",
    "Electric Shock",
    "Exposure To Gas",
    "Fainting",
    "Food Poisoning",
    "Graze / Cut",
    "Headache",
    "Head Injury",
    "Heart Attack",
    "High Blood Pressure",
    "Hypoglycemia / Sugar",
    "Menstrual Pain",
    "Nose Bleeding",
    "Road Accident",
    "Stomach Ache",
    "Stroke",
    "Wounds"

  ];

  // Description List Here
  var descList = [
    "Step 1 \n Sit the person upright \nStep 2\n Give 4 separate puffs of blue/grey reliever puffer. Shake the puffer.\n Step 3\n Wait 4 minutes. If there is no improvement, give 4 more separate puffs of blue/grey reliever, as with Step 2.\n Step 4\n.If breathing does not return to normal, call 112 / 114 for an ambulance. Tell operator that someone is having an asthma emergency. Keep giving the person 4 separate puffs",
    "Step 1 \n Stop any bleeding \n Step 2\n Immobilize the injured area: If you suspect they’ve broken a bone in their neck or back, help them stay as still as possible.\n Step 3\nApply cold to the area\n Step 4 \nHelp them get into a comfortable position, encourage them to rest, and reassure them. Cover them with a blanket or clothing to keep them warm \n Step 5\n Get professional help: Call 112/114 or help them get to the emergency department for professional care.",
    "Step 1 \n Stop any bleeding \n Step 2\n Immobilize the injured area: If you suspect they’ve broken a bone in their neck or back, help them stay as still as possible.\n Step 3\nApply cold to the area\n Step 4 \nHelp them get into a comfortable position, encourage them to rest, and reassure them. Cover them with a blanket or clothing to keep them warm \n Step 5\n Get professional help: Call 112/114 or help them get to the emergency department for professional care.",
    "Step 1 \n Flush the burned area with cool running water for several minutes \n Step 2 \n Call 911 for a severe burn (see below to learn if your burn is severe) \n Step 3 \nApply a burn ointment or spray for pain. \n Step 4 \n Take ibuprofen or acetaminophen for pain relief if necessary",
    "Step 1 \n Calm the person down and help them to rest, for example in a semi-seated position.\n Step 2 \n If the person is carrying their own nitrate medication (Nitro®), help them to take it. If the medication does not help within a few minutes, call for emergency. \n Step 3 \n Monitor their breathing and circulation. If the person goes lifeless, start resuscitation with 30 presses and 2 blows until aid arrives.",
    "Step 1 \n Determine the severity.If the adult is coughing, let them cough to continue to dislodge the choking hazard.\n Step 2 \n Call for emergency and Begin back blows. Use your dominant arm to deliver five powerful back blows between their shoulder blades. \n Step 3 \nBegin Heimlich maneuver or abdominal thrusts. Wrap your arms around their upper abdomen. Clench your fist and place it above their belly button. Grasp your fist with your other hand on top. Repeat five times. If they are pregnant or obese, wrap your arms around their chest. \n Step 5 \n If they become unconscious or stop breathing, lay them on the ground on a flat surface. and perform CPR",
    "Step 1 \n Let the baby cough. Check choking signs. A choking baby may be unable to cough or cry Call 112 / 114 \n Step 2 \n Begin back blows. Place the baby face down on your forearm, with their jaw cradled in your thumb and forefinger, and their head settled lower than their chest \n Step 3 \n Begin chest thrusts. Turn the infant over while still resting your forearm on their frontside. Sit down and place the baby’s back on your thigh, with their head still lower than the chest \n Step 4 \n  Repeat five back blows and five chest thrusts. Check the baby’s throat for the choking object after each cycle \n Step 5\n Begin CPR. If the baby becomes unconscious",
    "Step 1 \n If you suspect chemicals have entered your eye, begin flushing it immediately with cool water or an eye wash and continue to do so for a minimum of approximately 15 minutes. \n Step 2 \n Seek immediate medical attention by dialing 911 or going to the nearest emergency room. \n Step 3 \n If possible, take the container of the offending substance with you so that you can tell your doctor what you have been exposed to",
    "Check that the area is safe, then perform the following basic CPR steps:\n Step 1 \n Call 911 or ask someone else to. \n Step 2 \n Lay the person on their back and open their airway. \n Step 3 \n Check for breathing. If they are not breathing, start CPR. \n Step 4 \nPerform 30 chest compressions. \n Step 5 \n Perform two rescue breaths.Repeat until an ambulance or automated external defibrillator (AED) arrives.",
    "Step 1 \nCheck for breathing. Tilt their head back and look, If they are not breathing, call for emergency help. \n Step 2 \nGive five rescue breaths: tilt their head back, sealing your mouth over their mouth. Pinch their nose and blow into their mouth. Repeat this five times. \n Step 3\nGive 30 chest compressions. Push firmly in the middle of their chest and then release. \n Step 4 \n Repeat this 30 times.Give two rescue breaths then continue with cycles of 30 chest compressions and two rescue breaths until help arrives.",
    "Take these actions immediately while waiting for medical help: \n Step 1 \n Turn off the source of electricity, if possible. If not, move the source away from you and the person, using a dry, nonconducting object made of cardboard, plastic or wood. \n Step 2 \n Begin CPR if the person shows no signs of circulation, such as breathing, coughing or movement. \n Step 3 \n Try to prevent the injured person from becoming chilled. \n Step 4 \n Apply a bandage. Cover any burned areas with a sterile gauze bandage, if available, or a clean cloth. Don't use a blanket or towel, because loose fibers can stick to the burns.",
    "Step 1 \n Stop the source Remove the victim from contact with the chemical spill, airborne particles, or fumes. (Wear gloves or use other safety equipment as needed to protect yourself from exposure to the chemical.) \n Step 2 \n Clear the lungs Take the victim to fresh air.Perform rescue breathing or CPR, if needed. \n Step 3\n Flush eyes with cool water if affected for at least 15 minutes.Don't accidentally flush chemicals into an unaffected eye. Hold the head so that the injured eye is on the bottom. Flush from the nose downward. \n Step 4\n Clean the skinBrush water-activated chemicals, such as lime, from the skin, instead of using water. Be careful not to brush particles into the eyes.",
    "Step 1 \n Ask them to lie down. Check for other injuries and treat as appropriate.\n Step 2\n Kneel down next to them and raise their legs, supporting their ankles on your shoulders to help blood flow back to the brain.\n Step 3 \n Make sure that they have plenty of fresh air. Ask other people to move away and if you’re inside then ask someone to open a window. \n Step 4 \n Reassure the casualty and help them to sit up slowly.If they begin to feel faint again, lie them down again. \n Step 5 \n If they stay unresponsive, open their airway, check their breathing and prepare to perform CPR.",
    "Step 1 \n If you think someone has food poisoning, advise them to lie down and rest. If they’re vomiting, give them small sips of water to drink TO prevent dehydration. \n Step 2\n If they have accompanying diarrhoea or diarrhoea only, it is even more important to try to replace lost fluids and salts. \n Step 3 \n When they feel hungry again, advise them to eat light, bland, easily digested foods, such as bread, rice, crackers, or a banana. \n Step 4\n Do not drink alcohol, caffeine, or fizzy drinks.If they get worse and the vomiting and diarrhoea is persistent, particularly in the elderly, babies, or young children call for emergency help.",
    "Step 1 \n Wash your hands. This helps avoid infection. Stop the bleeding, apply gentle pressure with a clean bandage or cloth until bleeding stops.\n Step 2\n Clean the wound with water. Wash around the wound with soap without getting soap on wound. Remove any dirt or debris with tweezers cleaned with alcohol. See a doctor if you can't remove all debris.\n Step 3\n Apply a thin layer of an antibiotic ointment or petroleum jelly to keep the surface moist  If a rash appears, stop using the ointment.\n Step 4 \n Cover the wound. Apply a bandage, Covering the wound keeps it clean. If the injury is just a minor scrape or scratch, leave it uncovered.",
    "Step 1 \n Lie down in a dark, quiet room \n Step 2 \n Drink liquids preferably a lot of water \n Step 3\n Take acetaminophen or ibuprofen as needed\n Step 4 \n Put a cool, moist cloth across the forehead or eyes",
    "Step 1 \n Keep the person still. The injured person should lie down with the head and shoulders slightly elevated. Don't move the person unless necessary, and avoid moving the person's neck. If the person is wearing a helmet, don't remove it.\n Step 2 \n Stop any bleeding. Apply firm pressure to the wound with sterile gauze or a clean cloth. But don't apply direct pressure to the wound if you suspect a skull fracture.\n Step 3 \n Watch for changes in breathing and alertness. If the person shows no signs of circulation — no breathing, coughing or movement — begin CPR.",
    "Step 1 \n Call for emergency. Do not drive, it puts you and others at risk.\n Step 2 \n Chew and swallow an aspirin while waiting for emergency help. Aspirin helps keep the blood from clotting. Don't take aspirin if allergic. \n Step 3 \nTake nitroglycerin, if prescribed, as directed while waiting for emergency medical help.\n Step 4 \n Begin CPR if the person is unconscious, not breathing or if pulse can not be found to keep blood flowing after calling for emergency medical help. \n Step 5\nIf an automated external defibrillator (AED) is immediately available and the person is unconscious, follow the device instructions for using it.",
    "Step 1 \n Try to stay calm. This might not be easy if you are worried, but remember that being calm can actually reduce blood pressure. \n Step 2 \n Sit down and focus on your breathing. Take a few deep breaths and hold them for a few seconds before releasing.Take your blood pressure medication if your doctor has prescribed something for you.\n Step 3 \n A cup of hibiscus or chamomile tea can also help you feel calmer, it is a good idea to stock up on these teabags. However, avoid black tea or coffee at this time.\n Step 4 \n You can also eat a piece of dark chocolate to help the release of endorphins that will calm you down.",
    "Step 1 \n  Give them something sweet to eat or a non-diet drink.If someone has a diabetic emergency, their blood sugar levels can become too low. This can make them collapse. Giving them something sugary will help raise their blood sugar levels and improve their bodily function. Avoid giving them a diet drink, as it won’t have any sugar in it and will not help them.\n Step 2 \n  Reassure the person. Most people will gradually improve, but if in doubt, call for emergency. If you can’t call, get someone else to do it.",
    "Step 1 \n Exercise regularly. Physical activity helps ease menstrual cramps for some women. \n Step 2 \n Use heat. Soaking in a hot bath or using a heating pad, hot water bottle or heat patch on your lower abdomen might ease menstrual cramps.\n Step 3 \n Try dietary supplements. A number of studies have indicated that vitamin E, omega-3 fatty acids, vitamin B-1 (thiamin), vitamin B-6 and magnesium supplements might reduce menstrual cramps. \n Step 4 \n Reduce stress. Psychological stress might increase your risk of menstrual cramps and their severity.",
    "Step 1 \n Sit upright and lean forward. This discourages further bleeding. Gently blow your nose to clear your nose of blood clots.\n Step 2 \n Pinch your nose. Use your thumb and index finger to pinch your nostrils shut. Breathe through your mouth. Continue to pinch for 10 to 15 minutes. \n Step 3 \nIf the bleeding continues after 10 to 15 minutes, repeat holding pressure for another 10 to 15 minutes.  If the bleeding still continues, seek emergency care.\n Step 4 \n To prevent re-bleeding, don't pick or blow your nose and don't bend down for several hours.\n Step 5 \n If bleeding continues for 30 minutes or more call for emergency.",
    "Step 1 \n Check if the scene is safe to enter and accessible before attempting to render first aid. \n Step 2 \n Check for Injuries and Look for any bleeding. Immediately call for an emergency and Ask their advice to resuscitate victim \n Step 3 \n Check for obstructions in the mouth or throat. If there is no pulse and the victim is unresponsive and not breathing, perform CPR immediately. Place the victim’s body in the recovery position. \n Step 6\n Do not move the victim  the victim in case of Neck and spinal injuries unless they are in immediate danger.\n Step 8 \n Keep the victim warm",
    "Step 1 \n Avoid activity, especially after eating. \n Step 2\n .Treat Symptoms. Provide clear fluids to sip, such as water, broth, or fruit juice diluted with water.Serve bland foods, such as saltine crackers, plain bread, dry toast, rice, gelatin, or applesauce. \n Step 3 \n Avoid spicy or greasy foods and caffeinated or carbonated drinks until 48 hours after all symptoms have gone away.\n Step 4 \n Encourage the person to have a bowel movement.Ask doctor before giving any medicine for abdominal pain. Drugs can mask or worsen the pain.",
    "Step 1 \n Give someone you think is having a stroke the FAST test (As indicated on picture). Call for emergency immediately \n Step 2 \n Perform CPR, if necessary Most stroke patients don’t require CPR, But if victim is unconscious when you find them, check their pulse and breathing. If you find none, call for emergency and start CPR \n Step 3 \n Do not let that person go to sleep or talk you out of calling for emergency \n Step 4 \n Do not give them medication, food, or drinks \n Step 5 \n Do not drive yourself or someone else to the emergency room, its better to call for emergency",
    "Step 1 \n Wash Your Hands, Cleaning a wound with dirty hands increases the risk of infection. \n Step 2 \n Stop the Bleeding by applying pressure to the wound a with clean cloth nd allow the blood to clot. \n Step 3 \n Wash The Wound with running water. Be gentle while you clean it. Dry the wound with a clean cloth. \n Step 4 \n Apply an antibiotic ointment to the wound. The antibiotic will prevent the growth of bacteria that may lead to an infection. \n Step 5 \n Cover the Wound to protect the wound from outside elements as it heals. If the wound is minor, you don’t have to cover it with sterile dressing, and a simple bandage will do. "

  ];

  // Image Name List Here //
  var imgList = [
    "assets/asthma.jpg",
    "assets/splintarm.jpg",
    "assets/brokenleg.png",
    "assets/burns2.jpg",
    "assets/chest.png",
    "assets/chokingadult.jpg",
    "assets/chokingbbs.jpg",
    "assets/eye.jpg",
    "assets/CPR.jpg",
    "assets/drowning.jpg",
    "assets/electric.jpg",
    "assets/gas.png",
    "assets/fainting.jpg",
    "assets/foodpoisoning.jpg",
    "assets/graze.jpg",
    "assets/headache.jpg",
    "assets/headinjury.png",
    "assets/heartattack.jpg",
    "assets/bp.jpg",
    "assets/sugar.png",
    "assets/menstruationpain.jpg",
    "assets/nosebleedfirstaid.jpg",
    "assets/roadaccidents.jpg",
    "assets/stomachache.jpg",
    "assets/stroke.png",
    "assets/wounds.jpg"
  ];

  @override
  Widget build(BuildContext context) {
    // MediaQuery to get Device Width
    double width = MediaQuery.of(context).size.width * 0.6;
    return Scaffold(
      appBar: AppBar(
        // App Bar
        title: const Text(
          "Emergency First Aid",
          style: TextStyle(color: Colors.white),
        ),
        elevation: 0,
        // ignore: prefer_const_constructors
        backgroundColor: Colors.red,
      ),
      // Main List View With Builder
      body: ListView.builder(
        itemCount: imgList.length,
        itemBuilder: (context, index) {
          return GestureDetector(
            onTap: () {
              // This Will Call When User Click On ListView Item
              showDialogFunc(context, imgList[index], titleList[index], descList[index]);
            },
            // Card Which Holds Layout Of ListView Item
            child: Card(
              child: Row(
                children: <Widget>[
                  // ignore: sized_box_for_whitespace
                  Container(
                    width: 100,
                    height: 100,
                    child: Image.asset(imgList[index]),
                  ),
                  Padding(
                    padding: const EdgeInsets.all(10.0),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: <Widget>[
                        Text(
                          titleList[index],
                          style: const TextStyle(
                            fontSize: 20,
                            color: Colors.red,
                            fontWeight: FontWeight.bold,
                          ),
                        ),
                        const SizedBox(
                          height: 10,
                        ),
                        // ignore: sized_box_for_whitespace
                        Container(
                          width: width,
                          child: Text(
                            descList[index],
                            maxLines: 2,
                            style: const TextStyle(
                                fontSize: 15,
                                color: Colors.green,),
                          ),
                        ),
                      ],
                    ),
                  )
                ],
              ),
            ),
          );
        },
      ),
    );
  }
}

// This is a block of Model Dialog
showDialogFunc(context, img, title, desc) {
  return showDialog(
    context: context,
    builder: (context) {
      return Center(
        child: Material(
          type: MaterialType.transparency,
          child: Container(
            decoration: BoxDecoration(
              borderRadius: BorderRadius.circular(10),
              color: Colors.white,
            ),
            padding: const EdgeInsets.all(15),
            height: 900,
            width: MediaQuery.of(context).size.width * 0.8,
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.center,
              children: <Widget>[
                ClipRRect(
                  borderRadius: BorderRadius.circular(5),
                  child: Image.asset(
                    img,
                    width: 200,
                    height: 200,
                  ),
                ),
                const SizedBox(
                  height: 10,
                ),
                Text(
                  title,
                  style: const TextStyle(
                    fontSize: 25,
                    color: Colors.green,
                    fontWeight: FontWeight.bold,
                  ),
                ),
                // ignore: prefer_const_constructors
                SizedBox(
                  height: 10,
                ),
                // ignore: avoid_unnecessary_containers
                Container(
                  // width: 200,
                  child: Align(
                    alignment: Alignment.center,
                    child: Text(
                      desc,
                      maxLines: 50,
                      style: const TextStyle(fontSize: 15, color: Color.fromARGB(255, 9, 37, 24)),
                      textAlign: TextAlign.center,
                    ),
                  ),
                ),
              ],
            ),
          ),
        ),
      );
    },
  );
}
