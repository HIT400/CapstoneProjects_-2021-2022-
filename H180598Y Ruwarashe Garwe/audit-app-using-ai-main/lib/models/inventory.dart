class Inventory {
  String name;
  List<Items> items;

  Inventory({this.name, this.items = const []});

  Inventory.fromJson(Map<String, dynamic> json) {
    name = json['name'];
    if (json['items'] != null) {
      items = [];
      json['items'].forEach((v) {
        items.add(new Items.fromJson(v));
      });
    }
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['name'] = this.name;
    if (this.items != null) {
      data['items'] = this.items.map((v) => v.toJson()).toList();
    }
    return data;
  }
}

class Items {
  String itemName;
  String description;
  int count;

  Items({this.itemName, this.description, this.count});

  Items.fromJson(Map<String, dynamic> json) {
    itemName = json['item_name'];
    description = json['description'];
    count = json['count'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['item_name'] = this.itemName;
    data['description'] = this.description;
    data['count'] = this.count;
    return data;
  }
}
