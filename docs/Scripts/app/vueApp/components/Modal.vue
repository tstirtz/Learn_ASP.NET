<template>
    <div v-if="renderModal" class="modal modal-open show" id="myModal" tabindex="-1" role="dialog">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">
                <div class="modal-header text-center">
                    <h5 class="modal-title" id="exampleModalCenterTitle">{{ modalTitle}}</h5>
                    <button type="button" class="close" aria-label="Close">
                        <span aria-hidden="true" v-on:click="closeModal">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <p>{{ modalContent }}</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" v-on:click="closeModal">Close</button>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    export default{
        props: {
            modalContent: {
                type: String
            },
            modalTitle: {
                type: String
            }
        },
        data(){
            return{
                renderModal: true
            }
        },
        methods: {
            closeModal(){
                this.renderModal = false;
                $('#myModal').modal('hide');
            }
        }
    }
    $(window).on('load',function(){
        $('#myModal').modal('show');
    });
</script>
