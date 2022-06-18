class OnboardingContent {
  String image;
  String title;
  String description;
  bool curveLeft;

  OnboardingContent({this.image, this.title, this.description, this.curveLeft});
}

List<OnboardingContent> contents = [
  OnboardingContent(
      image: 'images/b2.jpg',
      title: 'What is Flex.',
      description:
          "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
      curveLeft: true),
  OnboardingContent(
      image: 'images/b3.jpg',
      title: 'How is it relevant.',
      description:
          "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
      curveLeft: false)
];
