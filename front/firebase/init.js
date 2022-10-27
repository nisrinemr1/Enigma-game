// Import the functions you need from the SDKs you need
import { initializeApp } from "firebase/app";
import { getFirestore } from "firebase/firestore";

// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
  apiKey: "AIzaSyBpOZFtuW0ctn1shEPxgjiKwySzuQMuTGo",
  authDomain: "enigma-hackathon2022.firebaseapp.com",
  projectId: "enigma-hackathon2022",
  storageBucket: "enigma-hackathon2022.appspot.com",
  messagingSenderId: "1008220979129",
  appId: "1:1008220979129:web:63776abb1bce073fd4c068",
  measurementId: "G-6JKFQCCN63"
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);

const db = getFirestore(app)

// EXPORT SERVICES
export{
    db
  }