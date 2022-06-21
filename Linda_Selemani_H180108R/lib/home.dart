import 'package:final_project1/offline.dart';
import 'package:flutter/material.dart';
import 'chat.dart';
import 'offline.dart';
import 'package:flutter_phone_direct_caller/flutter_phone_direct_caller.dart';

class Home extends StatelessWidget {
  static const String id = 'Home';


  @override
  Widget build(BuildContext context) {

    const number = '144';

    return Scaffold(
      backgroundColor: Colors.black,
      body: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        children: <Widget>[
          Align(
             alignment: Alignment.topCenter,
             child: Image.asset(
            'assets/newlogo.png',
            width: 400,
            height: 400,
          ),
          ),


          ElevatedButton(
             style: ElevatedButton.styleFrom(
               primary: Colors.green, // background
               onPrimary: Colors.red[100], // foreground
               minimumSize: const Size(200, 50),
               //side: BorderSide(width: 3, color: Colors.purple[200]),//
               shape: const RoundedRectangleBorder(
                 borderRadius: BorderRadius.all(Radius.circular(30))
               ),
             ),
               onPressed: (){Navigator.pushNamed(context, Chat.id);
               },
               child: const Text(' Lets Chat!'),
          ),

           const SizedBox(height: 20),
           ElevatedButton(
             style: ElevatedButton.styleFrom(
               primary: Colors.white, // background
               onPrimary: Colors.red, // foreground
               minimumSize: const Size(180, 50),
               shape: const RoundedRectangleBorder(
                   borderRadius: BorderRadius.all(Radius.circular(30))
               ),
             ),
               onPressed: (){Navigator.pushNamed(context, Offline.id);
             },
             child: const Text('Offline Help Service'),
           ),
          const SizedBox(height: 20),

          ElevatedButton(
            style: ElevatedButton.styleFrom(
              primary: Colors.red, // background
              onPrimary: Colors.white, // foreground
              minimumSize: const Size(90, 50),
              shape: const RoundedRectangleBorder(
                  borderRadius: BorderRadius.all(Radius.circular(30))
              ),
            ),
            onPressed: () async {
              await FlutterPhoneDirectCaller.callNumber(number);
            },
            child: const Text('Emergency Dial'),
          ),
         ],
        ),
      );

  }
}
