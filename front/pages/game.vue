<template>
  <div class="home-page">

    <h1>Enigma game</h1>

    <p>hi {{localUser}}</p>

    <div v-for="data in enigma">


      <button :click="sendToUnity">Enigma by {{data.user}}</button>

    </div>

    <form @submit.prevent="submit">

      <input type="text" v-model="enigma.title" placeholder="Type your enigma sentence">

      <button> Send </button>

    </form>

  </div>
</template>


<script>
  export default {
    name: "game",
    data() {
      return {
        enigma: [{
          title: "hello",
          user: "test"
        }],
        localUser: ""
      }
    },

    methods: {

      submit() {

        // ANCHOR Const : variable jamais modifier (read only), let: variable modifiable uniquement dans la fonction, var: variable modifiable et utilisable dans plusieurs fonctions

        let isAscii = [...this.enigma.title].some(char => char.charCodeAt(0) > 127);

        //IF BOTH INPUT ARE EMPTY
        if (!this.enigma.title || isAscii) {

          alert("Use acii characters only ;)");
          this.enigma.title = "";

        } else {

          // SEND INPUT VALUES TO DATA
          this.enigma.push({
            user: this.localUser,
            title: this.enigma.title
          });

          console.log(this.localUser)
          console.log(this.enigma.title)

          //SEND TO STORE
          this.$store.dispatch('enigma/add', {
            user: this.localUser,
            title: this.enigma.title
          });

        }

      },


      sendToUnity(){
        console.log(this.enigma.title)
      }
    },

    mounted() {
      if (!localStorage.getItem('storedData')) {
        this.$router.push({
          path: "/"
        });
      } else {
        this.localUser = localStorage.getItem('storedData');
      }
    }
  }

</script>
