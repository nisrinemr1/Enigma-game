<template>
  <div class="home-page">
    <div class="home-container">

      <form @submit.prevent="getUserName" placeholder="Username">
        <h1>Welcome to Enigma</h1>

        <h3>Please, enter your user name:</h3>

        <div class="inputUserName">
          <label for="name"> User name: </label>
          <input type="text" v-model="userName">
        </div>


        <button class="play-btn">Let's play</button>
      </form>

      <div class="footer">
        <h2>Hackathon 2022 🤍</h2>
        <h2> Shaila-GAME, Scheherazad-GAME, Manon-GAME </h2>
        <h2> Lelanie-ASR, Juiette-ASR, Nisrine-WEB </h2>
      </div>

    </div>

  </div>
</template>


<script>
  import Webgl from '~/component/webgl.vue';

  export default {
    name: "home",
    transition: {
      name: 'game',
      mode: 'out-in'
    },


    data() {
      return {
        userName: ""
      };
    },
    methods: {
      getUserName() {
        if (!this.userName) {
          alert("user name is empty");
        } else {
          localStorage.setItem("storedData", this.userName);
          alert("Welcome " + this.userName);
          this.$router.push({
            name: "game"
          });
        }
      }
    },
    components: {
      Webgl
    }
  }

</script>

<style lang="scss">
  .home-page {
    display: flex;
    justify-content: center;


    .home-container {
      width: 100%;
      height: 100vh;

      display: flex;
      flex-direction: column;
      align-items: center;
      justify-content: center;

      form {

        background: linear-gradient(to bottom, rgba(43, 237, 230, 0.1) 0%, rgba(43, 237, 230, 0.2) 100%);
        padding: 20px 60px;

        border: rgb(4, 235, 235) 10px double;

        display: flex;
        flex-direction: column;
        align-items: flex-start;


        h3 {
          padding-bottom: 20px;
        }

        .inputUserName {
          width: 50%;
          display: flex;
          flex-direction: column;
          justify-content: flex-start;

        }

        .play-btn {

          margin-top: 30px;
          justify-content: flex-end;
        }

      }
      .footer{
        position: absolute;
        bottom: 0;
        text-align: center;
      }
    }

  }

</style>
