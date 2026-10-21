App.module("AddTask", function (AddTask, $, Backbone, Marionette) {
    AddTask.Layout = Marionette.Layout.extend({
        template: "add_task/templates/add_task_layout",
        regions: {
            textRegion: "#text-region"
        }
    });

    AddTask.InputView = Marionette.ItemView.extend({
        template: "add_task/templates/add_task_view",

        ui: {
            $task: "#txt-task"
        },

        events: {
            "click #btn-add": "addTask"
        },

        onRender: function () {

        },

        addTask: function () {
            var name = this.ui.$task.val();
            var tasks = App.request("tasks:entities");
            if(tasks){                
                tasks.add({
                    name: name
                });   
            } 
            
             this.ui.$task.val("");          
        }
    });

    AddTask.on("start", function () {
        var layout = new AddTask.Layout();
        var view = new AddTask.InputView();

        App.topRegion.show(layout);

        layout.textRegion.show(view);
    });



    App.on("initialize:after", function () {
        App.module("AddTask").start();
    });
});