<template scr="../assets/webgl/canva.html">

  <div class="gameCanvas">

    <!-- <iFrame src="../assets/webgl/canva.html">
        </iFrame> -->
    <canvas id="unity-canvas" width=960 height=600>{{runWebGL}}</canvas>

  </div>

</template>

<script>
  export default {


    // mounted() {
    //   this.runWebGL()
    // }
    // methods: {
      

    // }

</script>

<style lang="scss">
  .gameCanvas {
    width: 100%;

    iFrame {
      width: 100%;
      background-color: pink;
    }
  }

</style>
