<template> 
   <!-- <Unity  width="1000" height="600" unityLoader="http://localhost:8888/group_project/i3_hackathon/webgl/Build/Build.loader.js"></Unity>  -->
<!-- <iframe src="http://192.168.3.47/game-test/index.html" width="1000" height="600"></iframe> -->
<iframe src="https://hackathon22.interface3.be/Enigma/FinalGame/index.html" width="1000" height="600"></iframe>

</template>

<script>
  import Unity from 'vue-unity-webgl'
 export default {
  components:{Unity}

 }
</script>

<style lang="scss">

   iframe{
      border: none;
      width: 100%;
      height: 100%;
   }

</style>