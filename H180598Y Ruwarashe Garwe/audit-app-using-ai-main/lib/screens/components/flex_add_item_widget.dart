import 'package:flutter/material.dart';

class FlexAddItemWidget extends StatelessWidget {
  final Function press;
  final String text;
  const FlexAddItemWidget({Key key, this.press, this.text}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: EdgeInsets.only(top: 16),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          Text(
            text ?? "",
            style: TextStyle(
                color: Colors.black, fontWeight: FontWeight.bold, fontSize: 16),
          ),
          GestureDetector(
            child: Icon(
              Icons.add_circle,
              size: 40,
              color: Theme.of(context).primaryColor,
            ),
            onTap: press != null ? press : () {},
          ),
        ],
      ),
    );
  }
}
