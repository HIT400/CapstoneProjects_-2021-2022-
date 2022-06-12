import {StyleSheet} from 'react-native';

export const styles = StyleSheet.create({
  container: {
    flex: 1,
  },
  body: {
    flex: 1,
    margin: 20,
    justifyContent: 'space-evenly',
  },
  headingText: {
    textAlign: 'center',
    textTransform: 'capitalize',
    fontSize: 18,
    paddingHorizontal: 10,
    marginVertical: 10,
  },
  primaryButton: {
    backgroundColor: '#4caf4f',
    padding: 10,
    borderRadius: 10,
  },
  cancelButton: {
    backgroundColor: '#e53935',
    padding: 10,
    borderRadius: 10,
  },
  buttonText: {
    textAlign: 'center',
    textTransform: 'uppercase',
    fontWeight: 'bold',
  },
  form: {
    marginHorizontal: 5,
    justifyContent: 'space-evenly',
  },
  picker: {
    borderWidth: 0.5,
    borderRadius: 10,
    borderColor: '#757575',
    marginVertical: 10,
  },
  padding: {
    padding: 5,
  },
  border: {
    borderColor: '#757575',
    borderWidth: 0.5,
    borderRadius: 10,
  },
  secondaryButton: {
    backgroundColor: '#ffeb3b',
    padding: 10,
    borderRadius: 10,
  },
  defaultButton: {
    backgroundColor: '#00bcd4',
    padding: 10,
    borderRadius: 10,
  },
  textInput: {
    borderColor: '#d75369',
    backgroundColor: 'white',
    fontFamily: 'Rubik-Regular',
    color: 'black',
  },
  datePicker: {
    borderColor: '#757575',
    borderWidth: 0.5,
    borderRadius: 10,
    marginVertical: 10,
    padding: 10,
    // backgroundColor: '#757575',
  },
  details: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    marginVertical: 4,
  },
});
