<template>
    <div class="summary-container">
        <h1 class="display-4 text center view-header">Expense Summary</h1>
        <div id="piechart_3d"></div>
    </div>
</template>

<script type="text/javascript">
import store from "../store";

 export default {
    data(){
        return{
            sharedStore: store.data
        }
    }
 }

</script>
