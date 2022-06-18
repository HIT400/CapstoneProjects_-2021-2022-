from celery.decorators import task

from major_damage.models import MajorDamageRun


@task(name="run_model")
def run_majour_damage_model(model_id):
    model = MajorDamageRun.objects.get(id=model_id)
    print(f"Run {model} now")
