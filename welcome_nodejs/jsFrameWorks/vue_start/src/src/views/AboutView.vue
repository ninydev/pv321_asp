<template>
  <div class="about">
    <h1>This is an about page</h1>
    <button @click="doClick"> Click Me </button>
  </div>
</template>

<script setup>
  const doClick = () => {
    alert("U Click Button")
  }
</script>


<style>
@media (min-width: 1024px) {
  .about {
    min-height: 100vh;
    display: flex;
    align-items: center;
  }
}
</style>
