import 'package:flutter/material.dart';
import 'flex_icon_buttons.dart';

class FlexListedInventory extends StatelessWidget {
  final Widget leading;
  final String title;
  final Function onCopyPress;
  final Function onEditPress;
  final Function onDeletePress;

  const FlexListedInventory(
      {Key key,
      this.leading,
      this.title,
      this.onCopyPress,
      this.onEditPress,
      this.onDeletePress})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.only(top: 5),
      child: Container(
        width: MediaQuery.of(context).size.width,
        child: Flexible(
          child: Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  this.leading,
                  SizedBox(
                    width: 5,
                  ),
                  Container(
                    width: 1 / 3 * MediaQuery.of(context).size.width,
                    child: Text(
                      this.title,
                      overflow: TextOverflow.clip,
                      style: TextStyle(color: Color(0XFFA2A2A2)),
                    ),
                  )
                ],
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  FlexIconButton(
                    press: onCopyPress,
                    scaleFactor: 30,
                    iconColor: Color(0XFFA2A2A2),
                    borderColor: Color(0XFFA2A2A2),
                    icon: Icons.paste,
                  ),
                  FlexIconButton(
                    press: onEditPress,
                    scaleFactor: 30,
                    iconColor: Color(0XFFA2A2A2),
                    borderColor: Color(0XFFA2A2A2),
                    icon: Icons.edit,
                  ),
                  FlexIconButton(
                    press: onDeletePress,
                    scaleFactor: 30,
                    iconColor: Color(0XFFA2A2A2),
                    borderColor: Color(0XFFA2A2A2),
                    icon: Icons.delete,
                  ),
                ],
              ),
            ],
          ),
        ),
      ),
    );
  }
}
