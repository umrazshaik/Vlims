import { Injectable } from '@angular/core';
import { RequestContext, workflowconiguration } from '../model/models';
import { HttpbaseService } from '../shared/httpbase.service';

@Injectable({
  providedIn: 'root'
})
export class WorkflowServiceService {

  constructor(private http: HttpbaseService) { }
  getworkflow(objrequest: RequestContext) {
    debugger
    return this.http.postJsonLogin(objrequest, "api/workflowconiguration/getallworkflow");
}
addworkflow(objrequest: workflowconiguration) {
  debugger
  return this.http.postJsonLogin(objrequest, "api/workflowconiguration/saveworkflowconiguration");
}
}