/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the PutScheduledAction operation.
    /// Creates or updates a scheduled action for an Application Auto Scaling scalable target.
    /// 
    ///  
    /// <para>
    /// Each scalable target is identified by a service namespace, resource ID, and scalable
    /// dimension. A scheduled action applies to the scalable target identified by those three
    /// attributes. You cannot create a scheduled action until you register the scalable target
    /// using <a>RegisterScalableTarget</a>.
    /// </para>
    ///  
    /// <para>
    /// To update an action, specify its name and the parameters that you want to change.
    /// If you don't specify start and end times, the old values are deleted. Any other parameters
    /// that you don't specify are not changed by this update request.
    /// </para>
    ///  
    /// <para>
    /// You can view the scheduled actions using <a>DescribeScheduledActions</a>. If you are
    /// no longer using a scheduled action, you can delete it using <a>DeleteScheduledAction</a>.
    /// </para>
    /// </summary>
    public partial class PutScheduledActionRequest : AmazonApplicationAutoScalingRequest
    {
        private DateTime? _endTime;
        private string _resourceId;
        private ScalableDimension _scalableDimension;
        private ScalableTargetAction _scalableTargetAction;
        private string _schedule;
        private string _scheduledActionName;
        private ServiceNamespace _serviceNamespace;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time for the scheduled action to end.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier of the resource associated with the scheduled action. This string consists
        /// of the resource type and unique identifier.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ECS service - The resource type is <code>service</code> and the unique identifier
        /// is the cluster name and service name. Example: <code>service/default/sample-webapp</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spot fleet request - The resource type is <code>spot-fleet-request</code> and the
        /// unique identifier is the Spot fleet request ID. Example: <code>spot-fleet-request/sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMR cluster - The resource type is <code>instancegroup</code> and the unique identifier
        /// is the cluster ID and instance group ID. Example: <code>instancegroup/j-2EEZNYKUA1NTV/ig-1791Y4E1L8YI0</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AppStream 2.0 fleet - The resource type is <code>fleet</code> and the unique identifier
        /// is the fleet name. Example: <code>fleet/sample-fleet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DynamoDB table - The resource type is <code>table</code> and the unique identifier
        /// is the resource ID. Example: <code>table/my-table</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DynamoDB global secondary index - The resource type is <code>index</code> and the
        /// unique identifier is the resource ID. Example: <code>table/my-table/index/my-table-index</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Aurora DB cluster - The resource type is <code>cluster</code> and the unique identifier
        /// is the cluster name. Example: <code>cluster:my-db-cluster</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon SageMaker endpoint variants - The resource type is <code>variant</code> and
        /// the unique identifier is the resource ID. Example: <code>endpoint/my-end-point/variant/KMeansClustering</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ScalableDimension. 
        /// <para>
        /// The scalable dimension. This parameter is required if you are creating a scheduled
        /// action. This string consists of the service namespace, resource type, and scaling
        /// property.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ecs:service:DesiredCount</code> - The desired task count of an ECS service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:spot-fleet-request:TargetCapacity</code> - The target capacity of a Spot
        /// fleet request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>elasticmapreduce:instancegroup:InstanceCount</code> - The instance count of
        /// an EMR Instance Group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>appstream:fleet:DesiredCapacity</code> - The desired capacity of an AppStream
        /// 2.0 fleet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dynamodb:table:ReadCapacityUnits</code> - The provisioned read capacity for
        /// a DynamoDB table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dynamodb:table:WriteCapacityUnits</code> - The provisioned write capacity for
        /// a DynamoDB table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dynamodb:index:ReadCapacityUnits</code> - The provisioned read capacity for
        /// a DynamoDB global secondary index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dynamodb:index:WriteCapacityUnits</code> - The provisioned write capacity for
        /// a DynamoDB global secondary index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>rds:cluster:ReadReplicaCount</code> - The count of Aurora Replicas in an Aurora
        /// DB cluster. Available for Aurora MySQL-compatible edition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sagemaker:variant:DesiredInstanceCount</code> - The number of EC2 instances
        /// for an Amazon SageMaker model endpoint variant.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ScalableDimension ScalableDimension
        {
            get { return this._scalableDimension; }
            set { this._scalableDimension = value; }
        }

        // Check to see if ScalableDimension property is set
        internal bool IsSetScalableDimension()
        {
            return this._scalableDimension != null;
        }

        /// <summary>
        /// Gets and sets the property ScalableTargetAction. 
        /// <para>
        /// The new minimum and maximum capacity. You can set both values or just one. During
        /// the scheduled time, if the current capacity is below the minimum capacity, Application
        /// Auto Scaling scales out to the minimum capacity. If the current capacity is above
        /// the maximum capacity, Application Auto Scaling scales in to the maximum capacity.
        /// </para>
        /// </summary>
        public ScalableTargetAction ScalableTargetAction
        {
            get { return this._scalableTargetAction; }
            set { this._scalableTargetAction = value; }
        }

        // Check to see if ScalableTargetAction property is set
        internal bool IsSetScalableTargetAction()
        {
            return this._scalableTargetAction != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule for this action. The following formats are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// At expressions - <code>at(<i>yyyy</i>-<i>mm</i>-<i>dd</i>T<i>hh</i>:<i>mm</i>:<i>ss</i>)</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Rate expressions - <code>rate(<i>value</i> <i>unit</i>)</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cron expressions - <code>cron(<i>fields</i>)</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// At expressions are useful for one-time schedules. Specify the time, in UTC.
        /// </para>
        ///  
        /// <para>
        /// For rate expressions, <i>value</i> is a positive integer and <i>unit</i> is <code>minute</code>
        /// | <code>minutes</code> | <code>hour</code> | <code>hours</code> | <code>day</code>
        /// | <code>days</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about cron expressions, see <a href="https://en.wikipedia.org/wiki/Cron">Cron</a>.
        /// </para>
        /// </summary>
        public string Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledActionName. 
        /// <para>
        /// The name of the scheduled action.
        /// </para>
        /// </summary>
        public string ScheduledActionName
        {
            get { return this._scheduledActionName; }
            set { this._scheduledActionName = value; }
        }

        // Check to see if ScheduledActionName property is set
        internal bool IsSetScheduledActionName()
        {
            return this._scheduledActionName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNamespace. 
        /// <para>
        /// The namespace of the AWS service. For more information, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#genref-aws-service-namespaces">AWS
        /// Service Namespaces</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        public ServiceNamespace ServiceNamespace
        {
            get { return this._serviceNamespace; }
            set { this._serviceNamespace = value; }
        }

        // Check to see if ServiceNamespace property is set
        internal bool IsSetServiceNamespace()
        {
            return this._serviceNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time for the scheduled action to start.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}