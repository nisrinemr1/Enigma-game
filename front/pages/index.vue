<template>
    <div class="home-page">
        
        <h1>Welcome to Enigma</h1>

        <h3>Please, enter your user name:</h3>

        <p>username: {{userName}}</p>
        
        <form @submit.prevent="getUserName" placeholder="Username">

            <input type="text" v-model="userName">

            <button>Let's play</button>
        </form>

        <Webgl/>

    </div>
</template>


<script>
import Webgl from '~/component/webgl.vue';

    export default {
    name: "home",
    data() {
        return {
            userName: ""
        };
    },
    methods: {
        getUserName() {
            if (!this.userName) {
                alert("user name is empty");
            }
            else {
                localStorage.setItem("storedData", this.userName);
                alert("Welcome " + this.userName);
                this.$router.push({ name: "game" });
            }
        }
    },
    components: { Webgl }
}
</script>