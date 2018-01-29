<template>
    <main>
      <v-content>
        <v-container fluid>

        <v-layout>
          <v-flex xs12 sm6 offset-sm3>
            <v-card>
            </v-card>
          </v-flex>
        </v-layout>

        </v-container>
      </v-content>
    </main>
</template>

<script>
import textButton from '../components/textButton'
import iconButton from '../components/IconButton'

const props={
  viewModel: Object,
}

export default {
  components:{
    textButton,
    iconButton
  },
  methods:{
    enter(){
      const command = this.viewModel.AddItem;
      if (command)
        command.Execute()
    }
  },
  props
}
</script>

<style>
</style>




